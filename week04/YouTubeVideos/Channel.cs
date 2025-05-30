/*
-------------------------------------
|             Channel               |
-------------------------------------
| - _channelName: string            |
-------------------------------------
| + Channel(channelName: string)    |
| + GetChannelName(): string        |
-------------------------------------
*/

class Channel
{
    public string _channelName;

    // Constructor
    Channel(string channelName)
    {
        _channelName = channelName;
    }

    // Methods
    public string GetChannelName()
    {
        return _channelName;
    }
}