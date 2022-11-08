#include <winsock2.h>
#pragma comment(lib, "ws2_32.lib")
#include <Windows.h>
#include <iostream>
#include <string>

#define SERVER "[SERVER]: "

using namespace std;

class Teacher {
public:
	string fullName;
	int degree;
	int workExperience;
	string subject;

	Teacher() {
		fullName = "- -";
		degree = 3;
		workExperience = 0;
		subject = "-";
	}

	Teacher(string _fullName, int _degree, int _workExperience, string _subject) {
		fullName = _fullName;
		degree = _degree;
		workExperience = _workExperience;
		subject = _subject;
	}
};

int numstud = 5;
int clientsCount = 0;
Teacher teachers[10];

string getResultString(Teacher teacher) {
	return "FullName: " + teacher.fullName + "; Degree: " + to_string(teacher.degree) + "; WorkExperience: " + to_string(teacher.workExperience) + "; Subject: " + teacher.subject + "\n";
}

DWORD WINAPI ThreadFunc(LPVOID client_socket) {
	SOCKET socket = ((SOCKET*)client_socket)[0];

	char buffer[1024];

	while (recv(socket, buffer, sizeof(buffer), 0)) {
		char action = buffer[0];
		string res = "";

		for (int i = 0; i < numstud; i++) {
			Teacher teacher = teachers[i];

			if (std::string(buffer).find(teacher.subject) != std::string::npos && teacher.workExperience >= 5) {
				res += getResultString(teacher);
				continue;
			}
		}

		strcpy(buffer, res.c_str());

		cout << SERVER << endl;
		cout << buffer << endl;

		send(socket, buffer, 1024, 0);
	}

	closesocket(socket);
	return 0;
}

void printClientsCount(int number) {
	if (number == 0) {
		cout << SERVER << "No connected clients" << endl;
		return;
	}

	cout << SERVER << number << " client(s) connected" << endl;
}

int main() {
	teachers[0] = Teacher("FirstName FSurname", 2, 4, "math");
	teachers[1] = Teacher("SecondName SSurname", 1, 5, "math");
	teachers[2] = Teacher("ThirdName TSurname", 1, 7, "physics");
	teachers[3] = Teacher("FourName FRSurname", 3, 2, "geography");
	teachers[4] = Teacher("FiveName FVSurname", 2, 4, "physics");

	WORD wVersionRequested;
	wVersionRequested = MAKEWORD(2, 2);
	WSADATA wsaData;
	int WSAStartupResult = WSAStartup(wVersionRequested, &wsaData);

	if (WSAStartupResult != 0) {
		cout << SERVER << "WSAStartup error" << endl;
		return 1;
	}

	SOCKET mySocket = socket(AF_INET, SOCK_STREAM, 0);

	if (mySocket == INVALID_SOCKET) {
		cout << SERVER << "Socket error" << endl;
		return 1;
	}

	struct sockaddr_in addressStruct;
	addressStruct.sin_family = AF_INET;
	addressStruct.sin_port = htons(1280);
	addressStruct.sin_addr.s_addr = 0;

	int addressStructSizeOf = sizeof(addressStruct);
	bind(mySocket, (struct sockaddr*)&addressStruct, addressStructSizeOf);

	listen(mySocket, 5);
	cout << SERVER << "Started listen" << endl;

	SOCKET clientSocket;
	sockaddr_in clientAddress;
	int clientAddressSize = sizeof(clientAddress);

	while ((clientSocket = accept(mySocket, (sockaddr*)&clientAddress, &clientAddressSize))) {
		clientsCount++;
		printClientsCount(clientsCount);

		DWORD thID;
		CreateThread(NULL, NULL, ThreadFunc, &clientSocket, NULL, &thID);
	}

	system("pause");
	return 0;
}