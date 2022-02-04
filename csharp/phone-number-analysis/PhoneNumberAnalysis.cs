using System;

public static class PhoneNumber
{
    private const string NY_CODE = "212";
    private const string FAKE_PATTERN = "555";
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneData = phoneNumber.Split('-');
        return (phoneData[0] == NY_CODE, phoneData[1] == FAKE_PATTERN, phoneData[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        => phoneNumberInfo.IsFake;
}
