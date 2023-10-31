﻿using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.MandatoryComponents.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAccessories.VideoCards.PCIVersionDir;
using Itmo.ObjectOrientedProgramming.Lab2.Prototype;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFiAdapters;

public class CurrentWifiAdapter : WifiAdapter, IPrototype<CurrentWifiAdapter>
{
    private int _version;
    private bool _bluetooth;
    private PCIVersions _wifiPciVersion;
    private int _wifiAdapterPower;
    private string _name;

    public CurrentWifiAdapter(
        string name,
        int version,
        bool bluetooth,
        PCIVersions pciVersions,
        int wifiAdapterPower)
    {
        _name = name;
        _version = version;
        _bluetooth = bluetooth;
        _wifiPciVersion = pciVersions;
        _wifiAdapterPower = wifiAdapterPower;
    }

    public override string Name => _name;
    public override int Version => _version;
    public override bool Bluetooth => _bluetooth;
    public override PCIVersions WifiPciVersions => _wifiPciVersion;
    public override int WifiAdapterPower => _wifiAdapterPower;
    public override bool AvailablePcie(MotherBoard motherBoard)
    {
        return motherBoard.Pci.EqualsForPciVersions(_wifiPciVersion);
    }

    public CurrentWifiAdapter Clone()
    {
        return new CurrentWifiAdapter(
        _name,
        _version,
        _bluetooth,
        _wifiPciVersion,
        _wifiAdapterPower);
    }

    public CurrentWifiAdapter SetName(string name)
    {
        CurrentWifiAdapter cloneWifi = Clone();
        _name = name;

        return cloneWifi;
    }

    public CurrentWifiAdapter SetVersion(int version)
    {
        CurrentWifiAdapter cloneWifi = Clone();
        _version = version;

        return cloneWifi;
    }

    public CurrentWifiAdapter SetBluetooth(bool bluetooth)
    {
        CurrentWifiAdapter cloneWifi = Clone();
        _bluetooth = bluetooth;

        return cloneWifi;
    }

    public CurrentWifiAdapter SetPci(PCIVersions pciVersions)
    {
        CurrentWifiAdapter cloneWifi = Clone();
        _wifiPciVersion = pciVersions;

        return cloneWifi;
    }

    public CurrentWifiAdapter SetPower(int power)
    {
        CurrentWifiAdapter cloneWifi = Clone();
        _wifiAdapterPower = power;

        return cloneWifi;
    }
}