#include "pch.h"

using namespace System;
using namespace System::Globalization;
using namespace System::Management;
using namespace System::Collections::Generic;

List<PropertyData^>^ getManagementSearcher(String^ clasName, String^ fields)
{
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
    CultureInfo^ current = CultureInfo::CurrentCulture;
    Console::WriteLine("Язык системы: {0}", current->DisplayName);   

    Console::WriteLine("\nИнформация о процессоре\n");    
    if (Environment::Is64BitOperatingSystem) Console::WriteLine("Разрядность: 64-bit");
    else Console::WriteLine("Разрядность: 32-bit");
   
    String^ fieldsProcessor = "Manufacturer,Name,Description";
    List<PropertyData^>^ Win32_Processor = getManagementSearcher("Win32_Processor", fieldsProcessor);
    for each (PropertyData^ info in Win32_Processor)
    {
        Console::WriteLine("{0}: {1}", info->Name, info->Value);
    }
    Console::WriteLine("Количество процессоров(ядер): {0}", Environment::ProcessorCount);
   
    Console::WriteLine("\nИнформация о памяти\n");
    Console::WriteLine("Выделено памяти для приложения: {0}", Environment::SystemPageSize);
    String^ OSFilter = "TotalVisibleMemorySize,FreePhysicalMemory,TotalVirtualMemorySize,FreeVirtualMemory";
    List<PropertyData^> ^OSPropertyes = getManagementSearcher("Win32_OperatingSystem", OSFilter);
    for each (PropertyData ^ prop in OSPropertyes)
    {
        double size = double::Parse(prop->Value->ToString()) / 1024 / 1024;
        Console::WriteLine("{0}: {1} {2}", prop->Name, Math::Round(size, 2), "GB");
    }
    Console::WriteLine("");
    String^ PhysicalMemory = "Name,SerialNumber,PartNumber,Manufacturer,SMBIOSMemoryType";
    List<PropertyData^> ^Win32_PhysicalMemory = getManagementSearcher("Win32_PhysicalMemory", PhysicalMemory);
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
            Console::WriteLine("");
        }
        else  Console::WriteLine("{0}: {1}", info->Name, info->Value);
    }
    Console::ReadLine();
   
    return 0;
}
