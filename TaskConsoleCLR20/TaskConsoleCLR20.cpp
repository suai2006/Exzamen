#include "pch.h"
// Программа написана с извлечение класса WMI

using namespace System;
using namespace System::Globalization;
using namespace System::Management;
using namespace System::Collections::Generic;

List<PropertyData^>^ getManagementSearcher(String^ clasName, String^ fields)
{
    //Обертка для получения данных Классов WMI
    if (fields == "") fields = "*";
    ManagementObjectSearcher^ searcher = gcnew ManagementObjectSearcher("SELECT " + fields + " FROM " + clasName);
    List<PropertyData^>^ properties = gcnew List<PropertyData^>{};
    try
    {
        for each (ManagementObject ^ info in searcher->Get())
        {
            for each (PropertyData ^ prop in info->Properties) properties->Add(prop);
        }       
    }
    catch (ManagementException^ e)
    {
        Console::WriteLine("Error: {0}", e->Message);
    }
    return properties;
}

int main(array<System::String ^> ^args)
{
    // Получаем данные о языке из namespace System::Globalization
    CultureInfo^ Lang = CultureInfo::CurrentCulture;    

    // Получаем данные о процессоре
    String^ fieldsProcessor = "Manufacturer,Name,Description";
    List<PropertyData^>^ Win32_Processor = getManagementSearcher("Win32_Processor", fieldsProcessor);

    // Получаем данные о памяти из данных операционной системы
    String^ OSFilter = "TotalVisibleMemorySize,FreePhysicalMemory,TotalVirtualMemorySize,FreeVirtualMemory";
    List<PropertyData^>^ OSPropertyes = getManagementSearcher("Win32_OperatingSystem", OSFilter);

    // Получаем данные о платах оперативной памяти
    String^ PhysicalMemory = "Name,SerialNumber,PartNumber,Manufacturer,SMBIOSMemoryType";
    List<PropertyData^>^ Win32_PhysicalMemory = getManagementSearcher("Win32_PhysicalMemory", PhysicalMemory);

    // Печатаем на экран
    Console::WriteLine("Язык системы: {0}", Lang->DisplayName);
    Console::WriteLine("\nИнформация о процессоре\n");    
    if (Environment::Is64BitOperatingSystem) Console::WriteLine("Разрядность: 64-bit");
    else Console::WriteLine("Разрядность: 32-bit");   
    
    for each (PropertyData^ info in Win32_Processor)
    {
        Console::WriteLine("{0}: {1}", info->Name, info->Value);
    }
    Console::WriteLine("Количество процессоров(ядер): {0}", Environment::ProcessorCount);
   
    Console::WriteLine("\nИнформация о памяти\n");
    Console::WriteLine("Выделено памяти для приложения: {0}", Environment::SystemPageSize);
   
    for each (PropertyData ^ prop in OSPropertyes)
    {
        double size = double::Parse(prop->Value->ToString()) / 1024 / 1024;
        Console::WriteLine("{0}: {1} {2}", prop->Name, Math::Round(size, 2), "GB");
    }
    Console::WriteLine("");
    int counter = 0;
    // получили 5 сторк, добавим разделитель после 5-й строки
    for each (PropertyData ^ info in Win32_PhysicalMemory)
    {
        if (info->Name == "SMBIOSMemoryType") 
        {
            String^ RAMtypeID = info->Value->ToString();
            if (RAMtypeID == "20") Console::WriteLine("RAM Type: {0}", "DDR");
            else if (RAMtypeID == "21") Console::WriteLine("RAM Type: {0}", "DDR2");
            else if (RAMtypeID == "22") Console::WriteLine("RAM Type: {0}", "DDR2 FB-DIMM");
            else if (RAMtypeID == "24") Console::WriteLine("RAM Type: {0}", "DDR3");
            else if (RAMtypeID == "26") Console::WriteLine("RAM Type: {0}", "DDR4");
            else Console::WriteLine("RAM Type: {0}", "Не известно");            
        }
        else  Console::WriteLine("{0}: {1}", info->Name, info->Value);
        counter++;
        if (counter == 5) 
        {
            Console::WriteLine("");
            counter = 0;
        }
    }
    Console::ReadLine();
   
    return 0;
}
