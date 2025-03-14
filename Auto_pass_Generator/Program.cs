using System;  // 'System' namespace ব্যবহার করা হচ্ছে, যাতে আমরা Console এবং Random ব্যবহার করতে পারি।

class PasswordGenerator  // একটি ক্লাস 'PasswordGenerator' তৈরি করা হচ্ছে।
{
    static void Main()  // 'Main' মেথড যেখানে প্রোগ্রামটি শুরু হবে।
    {
        Console.WriteLine("Enter the desired password length:");  // ব্যবহারকারীকে পাসওয়ার্ডের দৈর্ঘ্য ইনপুট দেওয়ার জন্য বলা হচ্ছে।
        
        string? input = Console.ReadLine();  // ব্যবহারকারীর ইনপুট নেওয়া হচ্ছে
        
        if (!int.TryParse(input, out int length) || length <= 0)  // ইনপুট ভ্যালিড কিনা চেক করা হচ্ছে।
        {
            Console.WriteLine("Invalid input! Please enter a valid positive number.");
            return;
        }

        string password = GeneratePassword(length);  // 'GeneratePassword' মেথড কল করে পাসওয়ার্ড তৈরি করা হচ্ছে।
        Console.WriteLine("Generated Password: " + password);  // তৈরি করা পাসওয়ার্ডটি কনসোলে দেখানো হচ্ছে।

        Console.WriteLine("Press Enter to exit...");  // প্রোগ্রামটি শেষ হওয়ার পর ব্যবহারকারীকে 'Enter' কী চাপার জন্য বলা হচ্ছে।
        Console.ReadLine();  // ব্যবহারকারী যখন Enter কী চাপবে, তখন প্রোগ্রামটি বন্ধ হবে।
    }

    static string GeneratePassword(int length)  // একটি মেথড 'GeneratePassword' যা পাসওয়ার্ডের দৈর্ঘ্য ইনপুট হিসেবে নেয় এবং একটি স্ট্রিং রিটার্ন করে।
    {
        const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";  // বড় হাতের অক্ষরের জন্য একটি স্ট্রিং কনস্ট্যান্ট।
        const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";  // ছোট হাতের অক্ষরের জন্য একটি স্ট্রিং কনস্ট্যান্ট।
        const string digits = "0123456789";  // ডিজিটস (০-৯) এর জন্য একটি স্ট্রিং কনস্ট্যান্ট।
        const string specialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/";  // বিশেষ চিহ্নের জন্য একটি স্ট্রিং কনস্ট্যান্ট।

        string allChars = upperCaseChars + lowerCaseChars + digits + specialChars;  // সব ধরনের অক্ষর একত্রিত করে একটি স্ট্রিং তৈরি করা হচ্ছে।
        Random random = new Random();  // একটি 'Random' অবজেক্ট তৈরি করা হচ্ছে, যা র্যান্ডম মান তৈরি করবে।

        char[] password = new char[length];  // একটি চর অ্যারে তৈরি করা হচ্ছে যার দৈর্ঘ্য পাসওয়ার্ডের দৈর্ঘ্যের সমান হবে।
        for (int i = 0; i < length; i++)  // একটি লুপ যা পাসওয়ার্ডের দৈর্ঘ্য অনুযায়ী প্রতিটি অক্ষর নির্বাচন করবে।
        {
            password[i] = allChars[random.Next(allChars.Length)];  // 'allChars' থেকে র্যান্ডম একটি অক্ষর নির্বাচন করে 'password' অ্যারেতে সংরক্ষণ করা হচ্ছে।
        }

        return new string(password);  // 'password' অ্যারের সব চরকে একত্রিত করে একটি স্ট্রিং ফেরত দেয়া হচ্ছে।
    }
}
