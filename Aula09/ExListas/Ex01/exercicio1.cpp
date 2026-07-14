#include <iostream>

int main() {
    std::cout << "Digite 5 Notas: " << std::endl;
    std::list<double> notas;
    double nota;
    for (int i = 0; i < 5; i++) {
        std::cin >> nota;
        notas.push_back(nota);
    }

    int maior = notas[0];
    int menor = notas[0];
    double soma = 0;
    for (int i = 1; i < notas.size(); i++) {
        int atual = notas[i];

        if (notas[i] > maior) {
            maior = atual;
        }
        if (notas[i] < menor) {
            menor = atual;
        }

        soma += atual;
    }

    double media = soma / notas.size();

    std::cout << "Maior nota: " << maior << std::endl;
    std::cout << "Menor nota: " << menor << std::endl;
    std::cout << "Media das notas: " << media << std::endl;
    return 0;
}