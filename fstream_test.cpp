#include <iostream>
#include <string>
#include <fstream>

int writeFile(const char* path, const char* text);
int readFile(const char* path);

int main() {
	writeFile("file.txt", "i like my cat!");
	readFile("file.txt");
	writeFile("file.txt", "my cat is beautyfull!");
	readFile("file.txt");
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
