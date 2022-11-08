#include <winsock2.h>
#pragma comment(lib, "ws2_32.lib")
#include <Windows.h>
#include <iostream>
#include <stdio.h>

#define CLIENT "[CLIENT]: "

using namespace std;

int main() {

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

		connect(mySocket, (sockaddr*)&addressStruct, sizeof(addressStruct));

		char buffer[1024];

		cout << CLIENT << "Choice subject(math, physics or geography): " << endl;

		fgets(buffer, sizeof(buffer), stdin);

		send(mySocket, buffer, 1024, 0);

		if (recv(mySocket, buffer, sizeof(buffer), 0) != 0) {
			cout << CLIENT << "Server answer: " << endl << buffer << endl;
		}

		closesocket(mySocket);
	}

	WSACleanup();
	system("pause");
	return 0;
}