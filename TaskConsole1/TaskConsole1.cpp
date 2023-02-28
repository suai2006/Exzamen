#include "pch.h"
using namespace System;
using namespace System::IO;
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
    Console::WriteLine("\nИмя компьютера: {0}", Environment::MachineName);
    array <DriveInfo^>^ driveInfo = DriveInfo::GetDrives();
    for each (DriveInfo ^ d in driveInfo)
    {
        Console::WriteLine("Drive {0}", d->Name);
        Console::WriteLine("Метка тома: {0}", d->VolumeLabel);
        Console::WriteLine("Файловая система: {0}", d->DriveFormat);
    }

    String^ fieldaDiskDrive = "Caption, MediaType,Model,SerialNumber,Size,InterfaceType,FirmwareRevision,Manufacturer";
    List<PropertyData^> ^Win32_DiskDrive = getManagementSearcher("Win32_DiskDrive", fieldaDiskDrive);
    for each (PropertyData ^ prop in Win32_DiskDrive)
    {
        if (prop->Name == "Size")
        {
            double size = double::Parse(prop->Value->ToString()) / 1024 / 1024 / 1024;
            Console::WriteLine("{0}: {1} {2}", prop->Name, Math::Round(size, 2), "GB");
        }
        else  Console::WriteLine("{0}: {1}", prop->Name, prop->Value);       
    }
    Console::WriteLine("Версия ОС: {0}", Environment::OSVersion);
    Console::ReadLine();
    return 0;
}