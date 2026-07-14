#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() 
{
    map<string, int> pessoas;
    cout << "Quantas pessoa deseja cadastrar? " << endl;
    int n;
    cin >> n;

    for (int i = 1; i <= n; i++) {
        string nome;
        int idade;
        cout << "Qual o nome da  " << i << "pessoa ? ";
        cin >> nome;
        cout << "Quantos anos tem a(o) " << nome << " ? ";
        cin >> idade;
        pessoas[nome] = idade;
    }
    cout << "Pessoas a cima d media: " << endl;
    int soma = 0;
    for (const auto& pessoa : pessoas) {
        soma += pessoa.second;
    }
    double media = soma / n;

    for (const auto& pessoa : pessoas) {
        if (pessoa.second > media) {
            cout << "Nome: " << pessoa.first << ", Idade: " << pessoa.second << endl;
        }
    }
    int maiorIdade = 0;
    string pessoaMaisVelha = "";
    cout << "Pessoa mais velha: " << endl;
    for (const auto& pessoa : pessoas) {
        if (pessoa.second > maiorIdade) {
            maiorIdade = pessoa.second;
            pessoaMaisVelha = pessoa.first;
        }
    }
    cout << "Nome: " << pessoaMaisVelha << ", Idade: " << maiorIdade << endl;

    int MenorIdade = 1000;
    string pessoaMaisNova = "";
    cout << "Pessoa mais nova: " << endl;
    for (const auto& pessoa : pessoas) {
        if (pessoa.second < MenorIdade) {
            MenorIdade = pessoa.second;
            pessoaMaisNova = pessoa.first;
        }
    }
    cout << "Nome: " << pessoaMaisNova << ", Idade: " << MenorIdade << endl;

    cout << "tera que remover pessoas com uma certa idade, qual idade deseja remover? " << endl;
    int idadeRemover;
    cin >> idadeRemover;
    
    for (auto x = pessoas.begin(); x != pessoas.end(); ) {
        if (x->second == idadeRemover) {
            x = pessoas.erase(x);
        } else {
            ++x;
        }
    }

    cout << "Pessoas restantes: " << endl;
    for (const auto& pessoa : pessoas) {
        cout << "Nome: " << pessoa.first << ", Idade: " << pessoa.second << endl;
    }

}