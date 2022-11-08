#include <winsock2.h>
#pragma comment (lib, "ws2_32.lib")
#include <Windows.h>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <process.h>

#define SERVER "[SERVER]: "

using namespace std;


int main() {
	WORD wVersionRequested;
	wVersionRequested = MAKEWORD(2, 2);
	WSADATA wsaData;
	int WSAStartupResult = WSAStartup(wVersionRequested, &wsaData);

	if (WSAStartupResult != 0) {
		cout << SERVER << "WSAStartup error" << endl;
		return 1;
	}

	SOCKET mySocket = socket(AF_INET, SOCK_DGRAM, 0);

	if (mySocket == INVALID_SOCKET) {
		cout << SERVER << "Socket error" << endl;
		return 1;
	}

	struct sockaddr_in addressStruct;
	addressStruct.sin_family = AF_INET;
	addressStruct.sin_port = htons(1024);
	addressStruct.sin_addr.s_addr = 0;

	int addressStructSizeOf = sizeof(addressStruct);
	bind(mySocket, (struct sockaddr*)&addressStruct, addressStructSizeOf);

	char buffer[200];

	int rv = recvfrom(mySocket, buffer, lstrlen((LPCWSTR)buffer), 0, (struct sockaddr*)&addressStruct, &addressStructSizeOf);
	buffer[rv] = '\0';

	cout << SERVER << "buffer = " << buffer << endl;

	char result[200];
	int counter = 0;

	int bufferLength = sizeof(buffer);

	if (bufferLength > 7) {
		int start = std::string(buffer).find('{');
		int end = std::string(buffer).find('}');

		if (start != string::npos || end != string::npos) {
			for (size_t i = std::string(buffer).find('{') + 1; i < std::string(buffer).find('}'); i++)
			{
				result[counter] = buffer[i];
				counter++;
			}

			result[counter] = '\0';
		}
		else {
			result[0] = '-';
			result[1] = '\0';
		}
	}

	cout << SERVER << "result = " << result << endl;

	sendto(mySocket, result, lstrlen((LPCWSTR)buffer), 0, (struct sockaddr*)&addressStruct, addressStructSizeOf);

	closesocket(mySocket);
	WSACleanup();
	return 0;
}

