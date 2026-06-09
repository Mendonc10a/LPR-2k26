#include <iostream>
#include <vector>

int main() {
    std::vector<int> numeros(10);
    int numeroPesquisa;

    std::cout << "Digite 10 números inteiros:\n";
    for (int i = 0; i < 10; ++i) {
        std::cin >> numeros[i];
    }

    std::cout << "Digite um número para pesquisar: ";
    std::cin >> numeroPesquisa;

    int ocorrencias = 0;
    std::vector<int> posicoes;

    // Pesquisa no vetor (um loop simples usando os índices)
    for (int i = 0; i < 10; i++) {
        if (numeros[i] == numeroPesquisa) {
            ocorrencias++;
            posicoes.push_back(i);
        }
    }

    // Exibição simplificada dos resultados
    if (ocorrencias > 0) {
        std::cout << "O número " << numeroPesquisa << " foi encontrado " << ocorrencias << " vezes.\n";
        std::cout << "Posições encontradas: ";
        

        for (int pos : posicoes) {
            std::cout << pos + 1 << " ";
        }
        std::cout << "\n";
    } else {
        std::cout << "O número " << numeroPesquisa << " não foi encontrado no vetor.\n";
    }

    return 0;
}