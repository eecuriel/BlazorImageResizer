// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ImageResizer.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using ImageResizer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\_Imports.razor"
using ImageResizer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Pages\FileUpload.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Pages\FileUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Pages\FileUpload.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Pages\FileUpload.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileUpload")]
    public partial class FileUpload : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Pages\FileUpload.razor"
 
    private CancellationTokenSource cancelation;
    private bool displayProgress;
    private EditContext editContext;
    private Person person;
    private int progressPercent;

    protected override void OnInitialized()
    {
        cancelation = new CancellationTokenSource();
        person = new Person();
        editContext = new EditContext(person);
    }

    private void OnChange(InputFileChangeEventArgs eventArgs)
    {
        person.Picture = eventArgs.File;
        editContext.NotifyFieldChanged(FieldIdentifier.Create(() => person.Picture));
    }

    private async Task OnSubmit()
    {
        using var file = File.OpenWrite(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
        using var stream = person.Picture.OpenReadStream();

        var buffer = new byte[4 * 1096];
        int bytesRead;
        double totalRead = 0;

        displayProgress = true;

        while ((bytesRead = await stream.ReadAsync(buffer, cancelation.Token)) != 0)
        {
            totalRead += bytesRead;
            await file.WriteAsync(buffer, cancelation.Token);

            progressPercent = (int)((totalRead / person.Picture.Size) * 100);
            StateHasChanged();
        }

        displayProgress = false;
    }

    public void Dispose()
    {
        cancelation.Cancel();
    }

    public class Person
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; } = "Pranav";

        [Required]
        [FileValidation(new[] { ".png", ".jpg" })]
        public IBrowserFile Picture { get; set; }
    }

    private class FileValidationAttribute : ValidationAttribute
    {
        public FileValidationAttribute(string[] allowedExtensions)
        {
            AllowedExtensions = allowedExtensions;
        }

        private string[] AllowedExtensions { get; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = (IBrowserFile)value;

            var extension = System.IO.Path.GetExtension(file.Name);

            if (!AllowedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase))
            {
                return new ValidationResult($"File must have one of the following extensions: {string.Join(", ", AllowedExtensions)}.", new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
