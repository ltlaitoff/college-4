#include <winsock2.h>
#pragma comment (lib, "ws2_32.lib")
#include <Windows.h>
#include <iostream>
#include <stdlib.h>

#define CLIENT "[CLIENT]: "

using namespace std;

int main() {
	WORD wVersionRequested;
	WSADATA wsaData;
	wVersionRequested = MAKEWORD(2, 2);
	int WSAStartupResult = WSAStartup(wVersionRequested, &wsaData);

	if (WSAStartupResult != 0) {
		cout << CLIENT << "WSAStartup error" << endl;
		return 1;
	}

	SOCKET mySocket = socket(AF_INET, SOCK_DGRAM, 0);

	if (mySocket == INVALID_SOCKET) {
		cout << CLIENT << "Socket error" << endl;
		return 1;
	}

	struct sockaddr_in addressStruct;
	addressStruct.sin_family = AF_INET;
	addressStruct.sin_port = htons(1024);
	addressStruct.sin_addr.s_addr = inet_addr("127.0.0.1");

	int addressStructSizeOf = sizeof(addressStruct);

	char inputStringBuffer[200];

	cout << CLIENT << "Input string = " << endl;
	cin.getline(inputStringBuffer, 100, '\n');

	sendto(mySocket, inputStringBuffer, lstrlen((LPCWSTR)inputStringBuffer), 0, (struct sockaddr*)&addressStruct, addressStructSizeOf);

	char resultBuffer[200];
	int rv = recvfrom(mySocket, resultBuffer, lstrlen((LPCWSTR)resultBuffer), 0, (struct sockaddr*)&addressStruct, &addressStructSizeOf);

	resultBuffer[rv] = '\0';

	cout << CLIENT << "Result = " << resultBuffer << endl;

	closesocket(mySocket);
	WSACleanup();

	system("pause");
	return 0;
}

