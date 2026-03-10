#include <iostream>

using namespace std;

int main() {
    int A, B, C, D;

    cout << "Digite quatro numeros inteiros (A B C D): ";
    cin >> A >> B >> C >> D;

    int diferenca = (A * B) - (C * D);
    cout << "Diferenca :" << diferenca << endl;
    return 0;
}