﻿using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3.TopicDir;

public class Topic : TopicBase
{
    private readonly string? _topicName;
    private AddresseeBase? _addressee;

    public Topic(string? name, AddresseeBase? addressee)
    {
        _topicName = name;
        _addressee = addressee;
    }

    public override void SendMessage(IMessage message)
    {
        _addressee?.ReceiveMessage(message);
    }

    public bool MessageStatus(IMessage message)
    {
        var addressee = (AddresseUser?)_addressee;

        return addressee != null && addressee.FindMessageStatus(message);
    }
}