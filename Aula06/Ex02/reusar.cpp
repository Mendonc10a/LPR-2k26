#include <iostream>
#include <locale>

using namespace std;

double exercicioUm(int total) {
    double somaPares = 0;
    int contadorPares = 0;
    for (int i = 1; i <= total; i++) {
        int num;
        cout << "Digite o " << i << "º número: ";
        cin >> num;
        if (num % 2 == 0) {
            somaPares += num;
            contadorPares++;
        }
    }
    return (contadorPares > 0) ? (somaPares / contadorPares) : 0;
}

int exercicioTres(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++) {
        if (i % 3 == 0 && i % 2 != 0) {
            soma += i;
        }
    }
    return soma;
}

int exercicioQuatro(int num) {
    int quadrado = num * num;
    int soma = 0;
    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }
    return soma;
}

int main() 
{
    int opcao;
    cout << "Menu de Exercícios" << endl;
    cout << "1. Média dos números pares" << endl;
    cout << "2. Soma dos números ímpares múltiplos de 3" << endl;
    cout << "3. Soma dos dígitos do quadrado de um número" << endl;
    cout << "Escolha uma opção: ";
    cin >> opcao;

    switch (opcao)
    {
        case 1: {
            int total;
            cout << "Quantos números você deseja inserir? ";
            cin >> total;
            double media = exercicioUm(total);
            cout << "A média dos números pares é: " << media << endl;
            break;
        }
        case 2: {
            int inicio, fim;
            cout << "Digite o início do intervalo: ";
            cin >> inicio;
            cout << "Digite o fim do intervalo: ";
            cin >> fim;
            int soma = exercicioTres(inicio, fim);
            cout << "A soma dos números ímpares múltiplos de 3 é: " << soma << endl;
            break;
        }
        case 3: {
            int num;
            cout << "Digite um número inteiro: ";
            cin >> num;
            int somaDigitos = exercicioQuatro(num);
            cout << "A soma dos dígitos do quadrado do " << num << " é: " << somaDigitos << endl;
            break;
        }
        default:
            cout << "Opção inválida!" << endl;
    }

    return 0;
}