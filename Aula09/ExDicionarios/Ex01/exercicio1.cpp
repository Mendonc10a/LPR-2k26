#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, string> catalogo;

    for (int i = 1; i <= 5; i++) {
        string nome, genero;
        cout << "Jogo " << i << " Nome: ";
        cin >> nome;
        cout << "Jogo " << i << " Genero: ";
        cin >> genero;
        catalogo[nome] = genero;
    }

    string busca;
    cout << "Digite o nome do jogo para buscar: ";
    cin >> busca;

    auto it = catalogo.find(busca);

    if (it != catalogo.end()) {
        cout << "Genero: " << it->second << endl;
    } else {
        cout << "Jogo nao cadastrado!" << endl;
    }

    return 0;
}