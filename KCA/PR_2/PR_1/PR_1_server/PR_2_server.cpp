#include <winsock2.h>
#include <Windows.h>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>

#pragma comment (lib,"ws2_32.lib")
#define SERVER "[SERVER]: "

using namespace std;

int main(int argc)
{
	bool programWorking = true;

	WORD wVersionRequested;
	wVersionRequested = MAKEWORD(2, 2);
	WSADATA wsaData;
	int WSAStartupResult = WSAStartup(wVersionRequested, &wsaData);

	if (WSAStartupResult != 0) {
		cout << SERVER << "WSAStartup error" << endl;
		programWorking = false;
	}


	SOCKET mySocket = socket(AF_INET, SOCK_STREAM, 0);
	if (mySocket == INVALID_SOCKET) {
		cout << SERVER << "Socket error" << endl;
		programWorking = false;
	}

	struct sockaddr_in addressStruct;
	addressStruct.sin_family = AF_INET;
	addressStruct.sin_port = htons(1280);
	addressStruct.sin_addr.s_addr = htonl(INADDR_ANY);
	bind(mySocket, (struct sockaddr*)&addressStruct, sizeof(addressStruct));

	listen(mySocket, 5);
	cout << SERVER << "Started listen" << endl;

	while (programWorking)
	{
		char buf[255], res[100], b[255], * Res;

		sockaddr_in remote_addr;
		int size = sizeof(remote_addr);

		SOCKET newSocket = accept(mySocket, (struct sockaddr*)&remote_addr, &size);
		cout << SERVER << "Connected new client: " << remote_addr.sin_addr.s_addr << endl;

		while (recv(newSocket, b, sizeof(b), 0) != 0)
		{
			cout << SERVER << "Get data from client = " << remote_addr.sin_addr.s_addr << ": " << b << endl;

			string stringifiedCommand = b;
			if (stringifiedCommand == "q") {
				break;
			}

			if (stringifiedCommand == "close") {
				programWorking = false;
				break;
			}

			int firstNumber = (int)b[0] + (int)b[1] + (int)b[2];
			int secondNumber = (int)b[3] + (int)b[4] + (int)b[5];

			if (firstNumber == secondNumber) {
				Res = (char*)"yes";
			}
			else {
				Res = (char*)"no";
			}

			send(newSocket, Res, sizeof(Res) - 2, 0);

			cout << SERVER << "Send data on client = " << remote_addr.sin_addr.s_addr << ": " << Res << endl;
		}

		closesocket(newSocket);
		cout << SERVER << "Close socket connection on client = " << remote_addr.sin_addr.s_addr << endl;
	}

	WSACleanup();
	return 0;
}
