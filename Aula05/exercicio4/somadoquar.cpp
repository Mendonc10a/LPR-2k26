#include <iostream>

using namespace std;

int main() 
{
    int num, quadrado, soma = 0;

    cout << "Digite um número inteiro: ";
    cin >> num;
    quadrado = num * num;
    while (quadrado > 0)
    {
        soma += quadrado % 10;
        quadrado /= 10;
    }
    cout << "A soma dos dígitos do quadrado do " << num << " é: " << soma << endl;

}