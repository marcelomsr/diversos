// TestesDiversos.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <boost/function.hpp>
#include <boost/date_time/gregorian/gregorian.hpp>
#include <boost/date_time/local_time/local_time.hpp>
#include <boost/filesystem.hpp>

#include <iostream>

int main()
{
    const std::string& numero_ramal = "Local/09931031998983013@agentes-0004348f;1";

    std::string numero_ramal_tratado = numero_ramal;

    size_t found = numero_ramal.find('@');

    if (found != std::string::npos)
        numero_ramal_tratado = boost::algorithm::ireplace_first_copy(numero_ramal, "@", "\\\\@");

    std::cout << numero_ramal_tratado.c_str();
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
