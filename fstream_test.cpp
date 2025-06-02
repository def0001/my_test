#include <iostream>
#include <string>
#include <fstream>

int writeFile(const char* path, const char* text);
int readFile(const char* path);
void eraseCharArray(char array[]);

int main() {
	char text[1000] = "";
	char act[32] = "";
	char path[100] = "";

	while (true) {
		std::cout << "(act)> ";
		std::cin.getline(act, sizeof(act));

		if (std::strcmp(act, "write") == 0) {
			std::cout << "(text)> ";
			std::cin.getline(text, sizeof(text));
			std::cout << "(path)> ";
			std::cin.getline(path, sizeof(path));
			writeFile(path, text);
		} else if (std::strcmp(act, "read") == 0) {
			std::cout << "(path)> ";
			std::cin.getline(path, sizeof(path));
			readFile(path);
		} else if (std::strcmp(act, "e") == 0 || std::strcmp(act, "exit") == 0) {
			return 0;
		} else {
			std::cerr << "Error: unknow action \"" << act << "\"!\n";
		}

		eraseCharArray(text);
		eraseCharArray(act);
		eraseCharArray(path);
	}
}

int writeFile(const char* path, const char* text) {
	std::ofstream file(path);

	if (!file.is_open()) {
		std::cerr << "Error: can't open file \"" << path << "\".\n\a";
		return 1;
	}

	file << text;
	file.close();
	std::cout << "Succes updated file \"" << path << "\": " << text << "\n";
	return 0;
}

int readFile(const char* path) {
	std::ifstream file(path);

	if (!file.is_open()) {
		std::cerr << "Error: can't open file \"" << path << "\".\n\a";
		return 1;
	}

	std::string text;
	std::cout << "The text in file \"" << path << "\":\n";
	while (std::getline(file, text)) {
		std::cout << text << "\n";
	}

	file.close();
	return 0;
}

void eraseCharArray(char array[]) {
	int i = 0;
	for (i = 0; i < sizeof(array); i++) {
		array[i] = {};
	}
	i = {};
}
