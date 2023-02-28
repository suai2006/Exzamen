#include "pch.h"

using namespace System;
using namespace System::IO;
using namespace System::Globalization;
using namespace System::Windows::Forms;


int main(array<System::String ^> ^args)
{
    Console::WriteLine("\n�������� ����� Windows\n");
    Array^ specialFolders = Enum::GetValues(Environment::SpecialFolder::typeid);

    for each (Environment::SpecialFolder specialFolder in specialFolders)
    {
        if (specialFolder == Environment::SpecialFolder::ProgramFiles)
        {
            Console::WriteLine("{0}: {1}", specialFolder, Environment::GetFolderPath(specialFolder));
        }
    }

    InputLanguage^ locale = InputLanguage::CurrentInputLanguage;
    CultureInfo^ myCIintl = gcnew CultureInfo(locale->Culture->ToString(), false);

    Console::WriteLine("\n��������� ����������: {0}", myCIintl->DisplayName);
    Console::WriteLine("������� ���� � �����: {0}", DateTime::Now);

    

    return 0;
}