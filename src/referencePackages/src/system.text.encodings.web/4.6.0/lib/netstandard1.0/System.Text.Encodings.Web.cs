// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Text.Encodings.Web.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010015c01ae1f50e8cc09ba9eac9147cf8fd9fce2cfe9f8dce4f7301c4132ca9fb50ce8cbf1df4dc18dd4d210e4345c744ecb3365ed327efdbc52603faa5e21daa11234c8c4a73e51f03bf192544581ebe107adee3a34928e39d04e524a9ce729d5090bfd7dad9d10c722c0def9ccc08ff0a03790e48bcd1f9b6c476063e1966a1c4")]
[assembly: System.Reflection.AssemblyTitle("System.Text.Encodings.Web")]
[assembly: System.Reflection.AssemblyDescription("System.Text.Encodings.Web")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Text.Encodings.Web")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.26515.06")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.26515.06 @BuiltBy: dlab-DDVSOWINAGE059 @Branch: release/2.1 @SrcCode: https://github.com/dotnet/corefx/tree/30ab651fcb4354552bd4891619a0bdd81e0ebdbf")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyVersionAttribute("4.0.3.0")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.0.3.0 originated from source-build-reference-packages")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System.Text.Encodings.Web
{
    public abstract partial class HtmlEncoder : TextEncoder
    {
        public static HtmlEncoder Default { get { throw null; } }

        public static HtmlEncoder Create(TextEncoderSettings settings) { throw null; }

        public static HtmlEncoder Create(params Unicode.UnicodeRange[] allowedRanges) { throw null; }
    }

    public abstract partial class JavaScriptEncoder : TextEncoder
    {
        public static JavaScriptEncoder Default { get { throw null; } }

        public static JavaScriptEncoder Create(TextEncoderSettings settings) { throw null; }

        public static JavaScriptEncoder Create(params Unicode.UnicodeRange[] allowedRanges) { throw null; }
    }

    public abstract partial class TextEncoder
    {
        public abstract int MaxOutputCharactersPerInputCharacter { get; }

        public virtual void Encode(IO.TextWriter output, char[] value, int startIndex, int characterCount) { }

        public virtual void Encode(IO.TextWriter output, string value, int startIndex, int characterCount) { }

        public void Encode(IO.TextWriter output, string value) { }

        public virtual string Encode(string value) { throw null; }

        [CLSCompliant(false)]
        public abstract unsafe int FindFirstCharacterToEncode(char* text, int textLength);
        [CLSCompliant(false)]
        public abstract unsafe bool TryEncodeUnicodeScalar(int unicodeScalar, char* buffer, int bufferLength, out int numberOfCharactersWritten);
        public abstract bool WillEncode(int unicodeScalar);
    }

    public partial class TextEncoderSettings
    {
        public TextEncoderSettings() { }

        public TextEncoderSettings(TextEncoderSettings other) { }

        public TextEncoderSettings(params Unicode.UnicodeRange[] allowedRanges) { }

        public virtual void AllowCharacter(char character) { }

        public virtual void AllowCharacters(params char[] characters) { }

        public virtual void AllowCodePoints(Collections.Generic.IEnumerable<int> codePoints) { }

        public virtual void AllowRange(Unicode.UnicodeRange range) { }

        public virtual void AllowRanges(params Unicode.UnicodeRange[] ranges) { }

        public virtual void Clear() { }

        public virtual void ForbidCharacter(char character) { }

        public virtual void ForbidCharacters(params char[] characters) { }

        public virtual void ForbidRange(Unicode.UnicodeRange range) { }

        public virtual void ForbidRanges(params Unicode.UnicodeRange[] ranges) { }

        public virtual Collections.Generic.IEnumerable<int> GetAllowedCodePoints() { throw null; }
    }

    public abstract partial class UrlEncoder : TextEncoder
    {
        public static UrlEncoder Default { get { throw null; } }

        public static UrlEncoder Create(TextEncoderSettings settings) { throw null; }

        public static UrlEncoder Create(params Unicode.UnicodeRange[] allowedRanges) { throw null; }
    }
}

namespace System.Text.Unicode
{
    public sealed partial class UnicodeRange
    {
        public UnicodeRange(int firstCodePoint, int length) { }

        public int FirstCodePoint { get { throw null; } }

        public int Length { get { throw null; } }

        public static UnicodeRange Create(char firstCharacter, char lastCharacter) { throw null; }
    }

    public static partial class UnicodeRanges
    {
        public static UnicodeRange All { get { throw null; } }

        public static UnicodeRange AlphabeticPresentationForms { get { throw null; } }

        public static UnicodeRange Arabic { get { throw null; } }

        public static UnicodeRange ArabicExtendedA { get { throw null; } }

        public static UnicodeRange ArabicPresentationFormsA { get { throw null; } }

        public static UnicodeRange ArabicPresentationFormsB { get { throw null; } }

        public static UnicodeRange ArabicSupplement { get { throw null; } }

        public static UnicodeRange Armenian { get { throw null; } }

        public static UnicodeRange Arrows { get { throw null; } }

        public static UnicodeRange Balinese { get { throw null; } }

        public static UnicodeRange Bamum { get { throw null; } }

        public static UnicodeRange BasicLatin { get { throw null; } }

        public static UnicodeRange Batak { get { throw null; } }

        public static UnicodeRange Bengali { get { throw null; } }

        public static UnicodeRange BlockElements { get { throw null; } }

        public static UnicodeRange Bopomofo { get { throw null; } }

        public static UnicodeRange BopomofoExtended { get { throw null; } }

        public static UnicodeRange BoxDrawing { get { throw null; } }

        public static UnicodeRange BraillePatterns { get { throw null; } }

        public static UnicodeRange Buginese { get { throw null; } }

        public static UnicodeRange Buhid { get { throw null; } }

        public static UnicodeRange Cham { get { throw null; } }

        public static UnicodeRange Cherokee { get { throw null; } }

        public static UnicodeRange CherokeeSupplement { get { throw null; } }

        public static UnicodeRange CjkCompatibility { get { throw null; } }

        public static UnicodeRange CjkCompatibilityForms { get { throw null; } }

        public static UnicodeRange CjkCompatibilityIdeographs { get { throw null; } }

        public static UnicodeRange CjkRadicalsSupplement { get { throw null; } }

        public static UnicodeRange CjkStrokes { get { throw null; } }

        public static UnicodeRange CjkSymbolsandPunctuation { get { throw null; } }

        public static UnicodeRange CjkUnifiedIdeographs { get { throw null; } }

        public static UnicodeRange CjkUnifiedIdeographsExtensionA { get { throw null; } }

        public static UnicodeRange CombiningDiacriticalMarks { get { throw null; } }

        public static UnicodeRange CombiningDiacriticalMarksExtended { get { throw null; } }

        public static UnicodeRange CombiningDiacriticalMarksforSymbols { get { throw null; } }

        public static UnicodeRange CombiningDiacriticalMarksSupplement { get { throw null; } }

        public static UnicodeRange CombiningHalfMarks { get { throw null; } }

        public static UnicodeRange CommonIndicNumberForms { get { throw null; } }

        public static UnicodeRange ControlPictures { get { throw null; } }

        public static UnicodeRange Coptic { get { throw null; } }

        public static UnicodeRange CurrencySymbols { get { throw null; } }

        public static UnicodeRange Cyrillic { get { throw null; } }

        public static UnicodeRange CyrillicExtendedA { get { throw null; } }

        public static UnicodeRange CyrillicExtendedB { get { throw null; } }

        public static UnicodeRange CyrillicSupplement { get { throw null; } }

        public static UnicodeRange Devanagari { get { throw null; } }

        public static UnicodeRange DevanagariExtended { get { throw null; } }

        public static UnicodeRange Dingbats { get { throw null; } }

        public static UnicodeRange EnclosedAlphanumerics { get { throw null; } }

        public static UnicodeRange EnclosedCjkLettersandMonths { get { throw null; } }

        public static UnicodeRange Ethiopic { get { throw null; } }

        public static UnicodeRange EthiopicExtended { get { throw null; } }

        public static UnicodeRange EthiopicExtendedA { get { throw null; } }

        public static UnicodeRange EthiopicSupplement { get { throw null; } }

        public static UnicodeRange GeneralPunctuation { get { throw null; } }

        public static UnicodeRange GeometricShapes { get { throw null; } }

        public static UnicodeRange Georgian { get { throw null; } }

        public static UnicodeRange GeorgianSupplement { get { throw null; } }

        public static UnicodeRange Glagolitic { get { throw null; } }

        public static UnicodeRange GreekandCoptic { get { throw null; } }

        public static UnicodeRange GreekExtended { get { throw null; } }

        public static UnicodeRange Gujarati { get { throw null; } }

        public static UnicodeRange Gurmukhi { get { throw null; } }

        public static UnicodeRange HalfwidthandFullwidthForms { get { throw null; } }

        public static UnicodeRange HangulCompatibilityJamo { get { throw null; } }

        public static UnicodeRange HangulJamo { get { throw null; } }

        public static UnicodeRange HangulJamoExtendedA { get { throw null; } }

        public static UnicodeRange HangulJamoExtendedB { get { throw null; } }

        public static UnicodeRange HangulSyllables { get { throw null; } }

        public static UnicodeRange Hanunoo { get { throw null; } }

        public static UnicodeRange Hebrew { get { throw null; } }

        public static UnicodeRange Hiragana { get { throw null; } }

        public static UnicodeRange IdeographicDescriptionCharacters { get { throw null; } }

        public static UnicodeRange IpaExtensions { get { throw null; } }

        public static UnicodeRange Javanese { get { throw null; } }

        public static UnicodeRange Kanbun { get { throw null; } }

        public static UnicodeRange KangxiRadicals { get { throw null; } }

        public static UnicodeRange Kannada { get { throw null; } }

        public static UnicodeRange Katakana { get { throw null; } }

        public static UnicodeRange KatakanaPhoneticExtensions { get { throw null; } }

        public static UnicodeRange KayahLi { get { throw null; } }

        public static UnicodeRange Khmer { get { throw null; } }

        public static UnicodeRange KhmerSymbols { get { throw null; } }

        public static UnicodeRange Lao { get { throw null; } }

        public static UnicodeRange Latin1Supplement { get { throw null; } }

        public static UnicodeRange LatinExtendedA { get { throw null; } }

        public static UnicodeRange LatinExtendedAdditional { get { throw null; } }

        public static UnicodeRange LatinExtendedB { get { throw null; } }

        public static UnicodeRange LatinExtendedC { get { throw null; } }

        public static UnicodeRange LatinExtendedD { get { throw null; } }

        public static UnicodeRange LatinExtendedE { get { throw null; } }

        public static UnicodeRange Lepcha { get { throw null; } }

        public static UnicodeRange LetterlikeSymbols { get { throw null; } }

        public static UnicodeRange Limbu { get { throw null; } }

        public static UnicodeRange Lisu { get { throw null; } }

        public static UnicodeRange Malayalam { get { throw null; } }

        public static UnicodeRange Mandaic { get { throw null; } }

        public static UnicodeRange MathematicalOperators { get { throw null; } }

        public static UnicodeRange MeeteiMayek { get { throw null; } }

        public static UnicodeRange MeeteiMayekExtensions { get { throw null; } }

        public static UnicodeRange MiscellaneousMathematicalSymbolsA { get { throw null; } }

        public static UnicodeRange MiscellaneousMathematicalSymbolsB { get { throw null; } }

        public static UnicodeRange MiscellaneousSymbols { get { throw null; } }

        public static UnicodeRange MiscellaneousSymbolsandArrows { get { throw null; } }

        public static UnicodeRange MiscellaneousTechnical { get { throw null; } }

        public static UnicodeRange ModifierToneLetters { get { throw null; } }

        public static UnicodeRange Mongolian { get { throw null; } }

        public static UnicodeRange Myanmar { get { throw null; } }

        public static UnicodeRange MyanmarExtendedA { get { throw null; } }

        public static UnicodeRange MyanmarExtendedB { get { throw null; } }

        public static UnicodeRange NewTaiLue { get { throw null; } }

        public static UnicodeRange NKo { get { throw null; } }

        public static UnicodeRange None { get { throw null; } }

        public static UnicodeRange NumberForms { get { throw null; } }

        public static UnicodeRange Ogham { get { throw null; } }

        public static UnicodeRange OlChiki { get { throw null; } }

        public static UnicodeRange OpticalCharacterRecognition { get { throw null; } }

        public static UnicodeRange Oriya { get { throw null; } }

        public static UnicodeRange Phagspa { get { throw null; } }

        public static UnicodeRange PhoneticExtensions { get { throw null; } }

        public static UnicodeRange PhoneticExtensionsSupplement { get { throw null; } }

        public static UnicodeRange Rejang { get { throw null; } }

        public static UnicodeRange Runic { get { throw null; } }

        public static UnicodeRange Samaritan { get { throw null; } }

        public static UnicodeRange Saurashtra { get { throw null; } }

        public static UnicodeRange Sinhala { get { throw null; } }

        public static UnicodeRange SmallFormVariants { get { throw null; } }

        public static UnicodeRange SpacingModifierLetters { get { throw null; } }

        public static UnicodeRange Specials { get { throw null; } }

        public static UnicodeRange Sundanese { get { throw null; } }

        public static UnicodeRange SundaneseSupplement { get { throw null; } }

        public static UnicodeRange SuperscriptsandSubscripts { get { throw null; } }

        public static UnicodeRange SupplementalArrowsA { get { throw null; } }

        public static UnicodeRange SupplementalArrowsB { get { throw null; } }

        public static UnicodeRange SupplementalMathematicalOperators { get { throw null; } }

        public static UnicodeRange SupplementalPunctuation { get { throw null; } }

        public static UnicodeRange SylotiNagri { get { throw null; } }

        public static UnicodeRange Syriac { get { throw null; } }

        public static UnicodeRange Tagalog { get { throw null; } }

        public static UnicodeRange Tagbanwa { get { throw null; } }

        public static UnicodeRange TaiLe { get { throw null; } }

        public static UnicodeRange TaiTham { get { throw null; } }

        public static UnicodeRange TaiViet { get { throw null; } }

        public static UnicodeRange Tamil { get { throw null; } }

        public static UnicodeRange Telugu { get { throw null; } }

        public static UnicodeRange Thaana { get { throw null; } }

        public static UnicodeRange Thai { get { throw null; } }

        public static UnicodeRange Tibetan { get { throw null; } }

        public static UnicodeRange Tifinagh { get { throw null; } }

        public static UnicodeRange UnifiedCanadianAboriginalSyllabics { get { throw null; } }

        public static UnicodeRange UnifiedCanadianAboriginalSyllabicsExtended { get { throw null; } }

        public static UnicodeRange Vai { get { throw null; } }

        public static UnicodeRange VariationSelectors { get { throw null; } }

        public static UnicodeRange VedicExtensions { get { throw null; } }

        public static UnicodeRange VerticalForms { get { throw null; } }

        public static UnicodeRange YijingHexagramSymbols { get { throw null; } }

        public static UnicodeRange YiRadicals { get { throw null; } }

        public static UnicodeRange YiSyllables { get { throw null; } }
    }
}