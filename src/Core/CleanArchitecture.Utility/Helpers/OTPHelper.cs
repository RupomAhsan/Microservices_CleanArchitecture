namespace CleanArchitecture.Utility.Helpers;

public static class OTPHelper
{
    public static int GenerateOTP()
    {
        Random rnd = new Random();
        var otpNumber = (rnd.Next(100000, 999999));
        return otpNumber;
     }
    public static string GenerateOTPPrefix(int numberofChar)
    {
        string otp = string.Empty;
        Random RNG = new Random();
        const string range = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var chars = Enumerable.Range(0, numberofChar).Select(x => range[RNG.Next(0, range.Length)]);
        otp = new string(chars.ToArray());
        return otp;
    }
}
