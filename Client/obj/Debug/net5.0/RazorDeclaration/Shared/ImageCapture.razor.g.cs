// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ImageResizer.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    public partial class ImageCapture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
       

    private IList<string> imageDataUrls = new List<string>();
    public long ActualSize = 0;
    public long NewSize = 0;
    public string Measure ="" ;
    public string NewMeasure ="" ;
    private int mbSize = 1024;
    public IBrowserFile File = null;
    bool ActivarCampos = false;
    public int Dim1  = 300;
    public int Dim2  = 300;
    

private async Task DimChange(string Dim)
    {
            if (Dim == "sm")
            {
                Dim1 = 500;
                Dim2 = 500;
                ActivarCampos = false;
                await PreviewImgNewSize(File,Dim1,Dim2);
            }else if (Dim == "md")
            {
                Dim1 = 800;
                Dim2 = 800;
                ActivarCampos = false;
                await PreviewImgNewSize(File,Dim1,Dim2);
                

            }else if (Dim == "lg")
            {
                Dim1 = 1000;
                Dim2 = 1000;
                ActivarCampos = false;
                await PreviewImgNewSize(File,Dim1,Dim2);
            }else if (Dim == "cust")
            {
                ActivarCampos = true;
                await PreviewImgNewSize(File,Dim1,Dim2);
            }
            
                await PreviewImgNewSize(File,Dim1,Dim2);

    }

    private async Task OnInputFileChange(InputFileChangeEventArgs  e)
    {
        imageDataUrls.Clear();
        var maxAllowedFiles = 1;
        
        File = e.File;
        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
                if (imageFile.ContentType == "image/png" || imageFile.ContentType == "image/jpeg" || imageFile.ContentType == "image/gif" ) 
                    {
                    

                        var resizedImageFile = await imageFile.RequestImageFileAsync(imageFile.ContentType,Dim1 , Dim2);
                        var buffer = new byte[resizedImageFile.Size];
                        await resizedImageFile.OpenReadStream().ReadAsync(buffer);
                        var imageDataUrl =$"data:{imageFile.ContentType};base64,{Convert.ToBase64String(buffer)}";
                        imageDataUrls.Add(imageDataUrl);
                        ActualSize = imageFile.Size / mbSize;
                        
                        if (ActualSize >= mbSize){
                            Measure = "MB";
                            ActualSize = ActualSize / mbSize;
                        }else {

                            Measure = "KB";
                        }
                        await DimChange("sm");
                    }      
        }
    }

    private async Task PreviewImgNewSize(IBrowserFile  imageFile,int dim1, int dim2)
    {
        
                if (imageFile.ContentType == "image/png" || imageFile.ContentType == "image/jpeg" || imageFile.ContentType == "image/gif" ) 
                    {
                        var newresizedImageFile = await imageFile.RequestImageFileAsync(imageFile.ContentType,dim1 , dim2);
                        var buffer = new byte[newresizedImageFile.Size];
                        await newresizedImageFile.OpenReadStream().ReadAsync(buffer);
                        NewSize = newresizedImageFile.Size / mbSize;
                        
                        if (NewSize >= mbSize){
                            NewMeasure = "MB";
                            NewSize = NewSize / mbSize;
                        }else {

                            NewMeasure = "KB";
                        }
                    }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
