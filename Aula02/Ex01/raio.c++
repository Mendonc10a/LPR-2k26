#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    float raio;
    const float pi = 3.14159;
    cout << "Vamos descobrir a area de um circulo " << endl;
    cout << "Digite o raio: ";
    cin >> raio;
    float area = pi * (raio*raio);
    cout << fixed << setprecision(4);
    cout << "A area do seu circulo eh: "<< area << endl;

    return 0;
}