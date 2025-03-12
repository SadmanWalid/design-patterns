namespace DesignPatterns.SOLID.SingleResponsibility
/// <summary>
/// The <c>IUser</c> interface violates the Single Responsibility Principle (SRP)
/// because it has multiple responsibilities: user authentication, error logging, and email sending.
/// </summary>
/// <remarks>
/// According to the SRP, a class or interface should have only one reason to change, meaning it should have only one job or responsibility.
/// By combining user authentication, error logging, and email sending into a single interface, it becomes difficult to maintain and extend the code.
/// </remarks>
{

    // The IUser interface violates the Single Responsibility Principle (SRP)
    // because it has multiple responsibilities: user authentication, error logging, and email sending.
    public interface IUser
    {
        // Responsibility 1: User authentication
        bool Login(string username, string password);
        bool Registration(string username, string password);

        // Responsibility 2: Error logging
        void LogError(string errorMessage);

        // Responsibility 3: Email sending
        void SendEmail(string emailContent);
    }

    public interface IUserAuthentication
    {
        // Responsibility: User authentication
        bool Login(string username, string password);
        bool Registration(string username, string password);
    }

    public interface IErrorLogger
    {
        // Responsibility: Error logging
        void LogError(string errorMessage);
    }

    public interface IEmail
    {
        // Responsibility: Email sending
        void SendEmail(string emailContent);
    }

}