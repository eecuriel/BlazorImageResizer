#pragma checksum "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea8ed57666c72c79896b8d80b1df2842d43e25e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Select your image</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(2);
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                          OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "form-control form-control-lg");
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
 if (imageDataUrls.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<h4>Images</h4>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card col-md");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
#nullable restore
#line 16 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                 foreach (var imageDataUrl in imageDataUrls)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "rounded m-1");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 18 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                   imageDataUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Image Actual Size : ");
            __builder.AddContent(19, 
#nullable restore
#line 20 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                            ActualSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                        Measure

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card col-md");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body rounded m-1 input-group mb-3 form-check form-check-inline");
            __builder.AddMarkupContent(27, "<p>Select image size:</p>\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "radio");
            __builder.AddAttribute(30, "class", "form-check-input");
            __builder.AddAttribute(31, "style", "margin-left: 10px;");
            __builder.AddAttribute(32, "id", "small");
            __builder.AddAttribute(33, "name", "size");
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                                                                             () => DimChange("sm")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddMarkupContent(37, "<label for=\"Small\" class=\"form-check-label\">Small</label><br>\r\n                ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "radio");
            __builder.AddAttribute(40, "class", "form-check-input");
            __builder.AddAttribute(41, "style", "margin-left: 10px;");
            __builder.AddAttribute(42, "id", "medium");
            __builder.AddAttribute(43, "name", "size");
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                                                                              () => DimChange("md")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<label for=\"medium\" class=\"form-check-label\">Medium</label><br>\r\n                ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "radio");
            __builder.AddAttribute(49, "class", "form-check-input");
            __builder.AddAttribute(50, "style", "margin-left: 10px;");
            __builder.AddAttribute(51, "id", "large");
            __builder.AddAttribute(52, "name", "size");
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                                                                           () => DimChange("lg")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<label for=\"large\" class=\"form-check-label\">Large</label>\r\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "radio");
            __builder.AddAttribute(58, "class", "form-check-input");
            __builder.AddAttribute(59, "style", "margin-left: 10px;");
            __builder.AddAttribute(60, "id", "custom");
            __builder.AddAttribute(61, "name", "size");
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                                                                              () => DimChange("cust")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.AddMarkupContent(64, "<label for=\"custom\" class=\"form-check-label\">Custom</label>\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "card");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card-body");
            __builder.OpenElement(69, "p");
            __builder.AddContent(70, "New Size :  ");
            __builder.AddContent(71, 
#nullable restore
#line 39 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                        NewSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(72, " ");
            __builder.AddContent(73, 
#nullable restore
#line 39 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                 NewMeasure

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                 if (ActivarCampos)
                {
                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "form-group");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "form-control-sm");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                            Dim1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Dim1 = __value, Dim1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.AddMarkupContent(82, "<label for=\"px\" class=\"form-label\">px</label>\r\n                        ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control-sm");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                            Dim2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Dim2 = __value, Dim2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<label for=\"px\" class=\"form-label\">px</label>");
            __builder.CloseElement();
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "btn btn-primary");
            __builder.AddAttribute(92, "style", "margin-left: 5px;");
            __builder.AddAttribute(93, "onClick", 
#nullable restore
#line 55 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                                                                                            PreviewImgNewSize(File,Dim1,Dim2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, "Resize");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.AddMarkupContent(96, "<button class=\"btn btn-primary\" style=\"margin-left: 5px;\">Preview Image</button>\r\n                        ");
            __builder.AddMarkupContent(97, "<button class=\"btn btn-primary\" style=\"margin-left: 5px;\">Download Image</button>");
#nullable restore
#line 58 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"
                
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\eduar\Documents\Cursos\ImageResizer\Client\Shared\ImageCapture.razor"

}

#line default
#line hidden
#nullable disable
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
