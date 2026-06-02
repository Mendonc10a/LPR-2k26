#include <iostream>

using namespace std;

int inverterNum(int n) {
    int invertido = 0;
    while (n > 0) {
        int digito = n % 10;
        invertido = invertido * 10 + digito;
        n = n / 10;
    }
    return invertido;
}

int main() {
    int numD,resultado;
    cout << "Digite um numero inteiro: ";
    cin >> numD;

    resultado = inverterNum(numD);
    cout << "O numero invertido é: " << resultado << endl;

    return 0;
}
