#include <iostream>

using namespace std;

int main() {
    int A, B; // Declare as variáveis no início

    cout << "Digite um numero inteiro: ";
    cin >> A; // Lê o primeiro logo após a mensagem

    cout << "Digite outro numero inteiro: ";
    cin >> B; // Lê o segundo logo após a mensagem

    if (A % B == 0 || B % A == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Nao sao Multiplos" << endl;
    }

    return 0;
}