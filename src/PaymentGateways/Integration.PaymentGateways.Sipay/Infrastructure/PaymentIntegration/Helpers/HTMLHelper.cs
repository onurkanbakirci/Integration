using System.Text;
using RazorEngineCore;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Helpers;

public static class HTMLHelper
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="templateName"><inheritdoc/></param>
    /// <param name="templatePath"><inheritdoc/></param>
    /// <param name="model"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public static string GenerateTemplate<T>(string templateName, string templatePath, T model)
    {
        string template = GetTemplate(templateName, templatePath);

        var razorEngine = new RazorEngine();
        var modifiedTemplate = razorEngine.Compile(template);

        return modifiedTemplate.Run(model);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="templateName"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public static string GetTemplate(string templateName, string templatePath)
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string tmplFolder = Path.Combine(baseDirectory, templatePath);
        string filePath = Path.Combine(tmplFolder, $"{templateName}.cshtml");

        using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var sr = new StreamReader(fs, Encoding.Default);
        string mailText = sr.ReadToEnd();
        sr.Close();

        return mailText;
    }
}