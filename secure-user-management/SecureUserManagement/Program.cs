using Serilog;
using SecureUserManagement.Data;
using SecureUserManagement.Services;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("logs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    Log.Information("Application Started");

    var userStore = new InMemoryUserStore();
    var authService = new AuthenticationService(userStore);
    var encryptionService = new EncryptionService();

    // Register user
    authService.Register("john", "password123");
    Log.Information("User registered successfully");

    // Authenticate user
    bool loginSuccess = authService.Authenticate("john", "password123");

    if (loginSuccess)
        Log.Information("User login successful");
    else
        Log.Warning("User login failed");

    // Encryption Demo
    string sensitiveData = "Sensitive User Data";
    string encrypted = encryptionService.Encrypt(sensitiveData);
    string decrypted = encryptionService.Decrypt(encrypted);

    Log.Information("Encryption and Decryption completed successfully");
}
catch (Exception ex)
{
    Log.Error(ex, "An error occurred in the application");
}
finally
{
    Log.CloseAndFlush();
}