#include <winsock2.h>
#include <Windows.h>
#include <iostream>
#include <stdlib.h>

#pragma comment (lib, "ws2_32.lib")

#define CLIENT "[CLIENT]: "

using namespace std;

int main(int argc)
{
	bool programWorking = true;

	WORD wVersionRequested;
	WSADATA wsaData;
	wVersionRequested = MAKEWORD(2, 2);
	int WSAStartupResult = WSAStartup(wVersionRequested, &wsaData);

	if (WSAStartupResult != 0) {
		cout << CLIENT << "WSAStartup error" << endl;
		programWorking = false;
	}

	while (programWorking) {
		SOCKET mySocket = socket(AF_INET, SOCK_STREAM, 0);

		if (mySocket == INVALID_SOCKET) {
			cout << CLIENT << "Socket error" << endl;
			programWorking = false;
			break;
		}

		struct sockaddr_in addressStruct;
		addressStruct.sin_family = AF_INET;
		addressStruct.sin_port = htons(1280);
		addressStruct.sin_addr.s_addr = inet_addr("127.0.0.1");

		bool isConnected = false;

		while (true) {
			char buf[255], b[255];
			cout << CLIENT << "Enter command or string please: " << endl;
			cin.getline(buf, 100, '\n');

			string stringifiedCommand = buf;

			if (stringifiedCommand == "connect") {
				int connectResult = connect(mySocket, (struct sockaddr*)&addressStruct, sizeof(addressStruct));

				if (connectResult == SOCKET_ERROR) {
					cout << CLIENT << "Connect socket error";
					programWorking = false;
					break;
				}

				cout << CLIENT << "Connecting to server" << endl;

				isConnected = true;
				continue;
			}


			if (isConnected) {
				send(mySocket, buf, sizeof(buf), 0);

				if (stringifiedCommand == "q") {
					cout << CLIENT << "Client disconecting" << endl;

					isConnected = false;
					break;
				}

			}


			if (stringifiedCommand == "close") {
				cout << CLIENT << "Client closing" << endl;

				closesocket(mySocket);

				programWorking = false;
				break;
			}

			if (isConnected) {
				if (recv(mySocket, b, sizeof(b), 0) != 0) {
					b[strlen(b)] = '\0';
					cout << b << endl;
				}
			}
		}
	}

	WSACleanup();
	system("pause");
	return 0;
}

