using System;

namespace GroovyMail.javascript
{
    internal static class JsManager
    {
        #region script resources
        private static readonly string res_InitEditor = @"GroovyMail.javascript.InitEditor.js";

        private static readonly string res_GetBodyInnerHTML = @"GroovyMail.javascript.GetBodyInnerHTML.js";
        private static readonly string res_GetBodyOuterHTML = @"GroovyMail.javascript.GetBodyOuterHTML.js";
        private static readonly string res_GetBodyAttribute = @"GroovyMail.javascript.GetBodyAttribute.js";
        
        private static readonly string res_SetBodyInnerHTML = @"GroovyMail.javascript.SetBodyInnerHTML.js";
        private static readonly string res_SetBodyOuterHTML = @"GroovyMail.javascript.SetBodyOuterHTML.js";
        private static readonly string res_SetBodyAttribute = @"GroovyMail.javascript.SetBodyAttribute.js";
        private static readonly string res_SetBodyStyleProperty = @"GroovyMail.javascript.SetBodyStyleProperty.js";

        private static readonly string res_GetElementInnerHTML = @"GroovyMail.javascript.GetElementInnerHTML.js";
        private static readonly string res_GetElementOuterHTML = @"GroovyMail.javascript.GetElementOuterHTML.js";
        private static readonly string res_GetElementAttribute = @"GroovyMail.javascript.GetElementAttribute.js";

        private static readonly string res_SetElementInnerHTML = @"GroovyMail.javascript.SetElementInnerHTML.js";
        private static readonly string res_SetElementOuterHTML = @"GroovyMail.javascript.SetElementOuterHTML.js";
        private static readonly string res_SetElementAttribute = @"GroovyMail.javascript.SetElementAttribute.js";
        private static readonly string res_SetElementStyleProperty = @"GroovyMail.javascript.SetElementStyleProperty.js";

        private static readonly string res_InsertElement = @"GroovyMail.javascript.InsertElement.js";
        private static readonly string res_InsertInlineImage = @"GroovyMail.javascript.InsertInlineImage.js";
        
        private static readonly string res_CreateSpanForSelection = @"GroovyMail.javascript.CreateSpanForSelection.js";
        private static readonly string res_CreateDivForSelection = @"GroovyMail.javascript.CreateDivForSelection.js";
        #endregion script resources


        #region scripts
        public static string js_InitEditor { get; private set; } = string.Empty;

        public static string js_GetBodyInnerHTML { get; private set; } = string.Empty;
        public static string js_GetBodyOuterHTML { get; private set; } = string.Empty;
        public static string js_GetBodyAttribute { get; private set; } = string.Empty;

        public static string js_SetBodyInnerHTML { get; private set; } = string.Empty;
        public static string js_SetBodyOuterHTML { get; private set; } = string.Empty;
        public static string js_SetBodyAttribute { get; private set; } = string.Empty;
        public static string js_SetBodyStyleProperty { get; private set; } = string.Empty;

        public static string js_InsertElement { get; private set; } = string.Empty;
        public static string js_InsertInlineImage { get; private set; } = string.Empty;
        public static string js_CreateSpanForSelection { get; private set; } = string.Empty;
        public static string js_CreateDivForSelection { get; private set; } = string.Empty;

        public static string js_GetElementInnerHTML { get; private set; } = string.Empty;
        public static string js_GetElementOuterHTML { get; private set; } = string.Empty;
        public static string js_GetElementAttribute { get; private set; } = string.Empty;

        public static string js_SetElementInnerHTML { get; private set; } = string.Empty;
        public static string js_SetElementOuterHTML { get; private set; } = string.Empty;
        public static string js_SetElementAttribute { get; private set; } = string.Empty;
        public static string js_SetElementStyleProperty { get; private set; } = string.Empty;
        #endregion scripts


        private static string LoadScript(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
            {
                throw new Exception($"Resource '{resourceName}' not found.");
            }

            using (var reader = new System.IO.StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static void LoadScripts()
        {
            js_InitEditor = LoadScript(res_InitEditor);
            
            js_GetBodyInnerHTML = LoadScript(res_GetBodyInnerHTML);
            js_GetBodyOuterHTML = LoadScript(res_GetBodyOuterHTML);
            js_GetBodyAttribute = LoadScript(res_GetBodyAttribute);

            js_SetBodyInnerHTML = LoadScript(res_SetBodyInnerHTML);
            js_SetBodyOuterHTML = LoadScript(res_SetBodyOuterHTML);
            js_SetBodyAttribute = LoadScript(res_SetBodyAttribute);
            js_SetBodyStyleProperty = LoadScript(res_SetBodyStyleProperty);

            js_GetElementInnerHTML = LoadScript(res_GetElementInnerHTML);
            js_GetElementOuterHTML = LoadScript(res_GetElementOuterHTML);
            js_GetElementAttribute = LoadScript(res_GetElementAttribute);

            js_SetElementInnerHTML = LoadScript(res_SetElementInnerHTML);
            js_SetElementOuterHTML = LoadScript(res_SetElementOuterHTML);
            js_SetElementAttribute = LoadScript(res_SetElementAttribute);
            js_SetElementStyleProperty = LoadScript(res_SetElementStyleProperty);
        }
    }
}
