#include <iostream>
using namespace std;

void MultipleAndOut(int num1, int num2);

int main() {
	int num1, num2;

	cout << "Enter num1 value: ";
	cin >> num1;
	cout << "Enter num2 value: ";
	cin >> num2;

	MultipleAndOut(num1, num2);
	num1 = NULL;
	num2 = NULL;
	cout << "\n";
	main();
}

void MultipleAndOut(int num1, int num2) {
	cout << "Result: " << num1 << " * " << num2 << " = " << num1 * num2 << "\n";
}
