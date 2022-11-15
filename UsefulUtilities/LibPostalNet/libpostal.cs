// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace LibPostalNet
{
    public unsafe partial class LibpostalNormalizeResponse
    {
        internal static global::LibPostalNet.LibpostalNormalizeResponse __CreateInstance(global::System.SByte** native, global::System.UInt64 count)
        {
            var expansions = new string[count];
            for (ulong i = 0; i < count; i++)
            {
                var normalized = new IntPtr(native[i]);
                var str = Marshal.PtrToStringAnsi(normalized);
                expansions[i] = str;
            }

            libpostal.LibpostalExpansionArrayDestroy(native, count);

            return new global::LibPostalNet.LibpostalNormalizeResponse(expansions);
        }

        protected LibpostalNormalizeResponse(string[] expansions)
        {
            Expansions = expansions;
        }

        public string[] Expansions { get; private set; }
    }

    public unsafe partial class LibpostalNormalizeOptions : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr languages;

            [FieldOffset(8)]
            internal ulong num_languages;

            [FieldOffset(16)]
            internal ushort address_components;

            [FieldOffset(18)]
            internal byte latin_ascii;

            [FieldOffset(19)]
            internal byte transliterate;

            [FieldOffset(20)]
            internal byte strip_accents;

            [FieldOffset(21)]
            internal byte decompose;

            [FieldOffset(22)]
            internal byte lowercase;

            [FieldOffset(23)]
            internal byte trim_string;

            [FieldOffset(24)]
            internal byte drop_parentheticals;

            [FieldOffset(25)]
            internal byte replace_numeric_hyphens;

            [FieldOffset(26)]
            internal byte delete_numeric_hyphens;

            [FieldOffset(27)]
            internal byte split_alpha_from_numeric;

            [FieldOffset(28)]
            internal byte replace_word_hyphens;

            [FieldOffset(29)]
            internal byte delete_word_hyphens;

            [FieldOffset(30)]
            internal byte delete_final_periods;

            [FieldOffset(31)]
            internal byte delete_acronym_periods;

            [FieldOffset(32)]
            internal byte drop_english_possessives;

            [FieldOffset(33)]
            internal byte delete_apostrophes;

            [FieldOffset(34)]
            internal byte expand_numex;

            [FieldOffset(35)]
            internal byte roman_numerals;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0libpostal_normalize_options@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalNormalizeOptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalNormalizeOptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::LibPostalNet.LibpostalNormalizeOptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalNormalizeOptions(native.ToPointer(), skipVTables);
        }

        internal static global::LibPostalNet.LibpostalNormalizeOptions __CreateInstance(global::LibPostalNet.LibpostalNormalizeOptions.__Internal native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalNormalizeOptions(native, skipVTables);
        }

        private static void* __CopyValue(global::LibPostalNet.LibpostalNormalizeOptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalNormalizeOptions.__Internal));
            *(global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private LibpostalNormalizeOptions(global::LibPostalNet.LibpostalNormalizeOptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LibpostalNormalizeOptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LibpostalNormalizeOptions()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalNormalizeOptions.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LibpostalNormalizeOptions(global::LibPostalNet.LibpostalNormalizeOptions _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalNormalizeOptions.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance) = *((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)_0.__Instance);
        }

        ~LibpostalNormalizeOptions()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::LibPostalNet.LibpostalNormalizeOptions __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        // These constants are copied from libposta.h
        // TODO: Find a way to import the constants from the C library directly
        public const ushort LIBPOSTAL_ADDRESS_NONE = 0;
        public const ushort LIBPOSTAL_ADDRESS_ANY = (1 << 0);
        public const ushort LIBPOSTAL_ADDRESS_NAME = (1 << 1);
        public const ushort LIBPOSTAL_ADDRESS_HOUSE_NUMBER = (1 << 2);
        public const ushort LIBPOSTAL_ADDRESS_STREET = (1 << 3);
        public const ushort LIBPOSTAL_ADDRESS_UNIT = (1 << 4);
        public const ushort LIBPOSTAL_ADDRESS_LEVEL = (1 << 5);
        public const ushort LIBPOSTAL_ADDRESS_STAIRCASE = (1 << 6);
        public const ushort LIBPOSTAL_ADDRESS_ENTRANCE = (1 << 7);

        public const ushort LIBPOSTAL_ADDRESS_CATEGORY = (1 << 8);
        public const ushort LIBPOSTAL_ADDRESS_NEAR = (1 << 9);

        public const ushort LIBPOSTAL_ADDRESS_TOPONYM = (1 << 13);
        public const ushort LIBPOSTAL_ADDRESS_POSTAL_CODE = (1 << 14);
        public const ushort LIBPOSTAL_ADDRESS_PO_BOX = (1 << 15);
        public const ushort LIBPOSTAL_ADDRESS_ALL = ((1 << 16) - 1);

        public sbyte** Languages
        {
            get
            {
                return (sbyte**)((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->languages;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->languages = (global::System.IntPtr)value;
            }
        }

        public ulong NumLanguages
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->num_languages;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->num_languages = value;
            }
        }

        public ushort AddressComponents
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->address_components;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->address_components = value;
            }
        }

        public bool LatinAscii
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->latin_ascii != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->latin_ascii = (byte)(value ? 1 : 0);
            }
        }

        public bool Transliterate
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->transliterate != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->transliterate = (byte)(value ? 1 : 0);
            }
        }

        public bool StripAccents
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->strip_accents != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->strip_accents = (byte)(value ? 1 : 0);
            }
        }

        public bool Decompose
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->decompose != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->decompose = (byte)(value ? 1 : 0);
            }
        }

        public bool Lowercase
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->lowercase != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->lowercase = (byte)(value ? 1 : 0);
            }
        }

        public bool TrimString
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->trim_string != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->trim_string = (byte)(value ? 1 : 0);
            }
        }

        public bool DropParentheticals
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->drop_parentheticals != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->drop_parentheticals = (byte)(value ? 1 : 0);
            }
        }

        public bool ReplaceNumericHyphens
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->replace_numeric_hyphens != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->replace_numeric_hyphens = (byte)(value ? 1 : 0);
            }
        }

        public bool DeleteNumericHyphens
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_numeric_hyphens != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_numeric_hyphens = (byte)(value ? 1 : 0);
            }
        }

        public bool SplitAlphaFromNumeric
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->split_alpha_from_numeric != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->split_alpha_from_numeric = (byte)(value ? 1 : 0);
            }
        }

        public bool ReplaceWordHyphens
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->replace_word_hyphens != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->replace_word_hyphens = (byte)(value ? 1 : 0);
            }
        }

        public bool DeleteWordHyphens
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_word_hyphens != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_word_hyphens = (byte)(value ? 1 : 0);
            }
        }

        public bool DeleteFinalPeriods
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_final_periods != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_final_periods = (byte)(value ? 1 : 0);
            }
        }

        public bool DeleteAcronymPeriods
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_acronym_periods != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_acronym_periods = (byte)(value ? 1 : 0);
            }
        }

        public bool DropEnglishPossessives
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->drop_english_possessives != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->drop_english_possessives = (byte)(value ? 1 : 0);
            }
        }

        public bool DeleteApostrophes
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_apostrophes != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->delete_apostrophes = (byte)(value ? 1 : 0);
            }
        }

        public bool ExpandNumex
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->expand_numex != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->expand_numex = (byte)(value ? 1 : 0);
            }
        }

        public bool RomanNumerals
        {
            get
            {
                return ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->roman_numerals != 0;
            }

            set
            {
                ((global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)__Instance)->roman_numerals = (byte)(value ? 1 : 0);
            }
        }
    }

    public unsafe partial class LibpostalAddressParserResponse : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong num_components;

            [FieldOffset(8)]
            internal global::System.IntPtr components;

            [FieldOffset(16)]
            internal global::System.IntPtr labels;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0libpostal_address_parser_response@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalAddressParserResponse> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalAddressParserResponse>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::LibPostalNet.LibpostalAddressParserResponse __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalAddressParserResponse(native.ToPointer(), skipVTables);
        }

        internal static global::LibPostalNet.LibpostalAddressParserResponse __CreateInstance(global::LibPostalNet.LibpostalAddressParserResponse.__Internal native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalAddressParserResponse(native, skipVTables);
        }

        private static void* __CopyValue(global::LibPostalNet.LibpostalAddressParserResponse.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserResponse.__Internal));
            *(global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private LibpostalAddressParserResponse(global::LibPostalNet.LibpostalAddressParserResponse.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LibpostalAddressParserResponse(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LibpostalAddressParserResponse()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserResponse.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LibpostalAddressParserResponse(global::LibPostalNet.LibpostalAddressParserResponse _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserResponse.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance) = *((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)_0.__Instance);
        }

        ~LibpostalAddressParserResponse()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::LibPostalNet.LibpostalAddressParserResponse __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong NumComponents
        {
            get
            {
                return ((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->num_components;
            }

            set
            {
                ((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->num_components = value;
            }
        }

        public sbyte** Components
        {
            get
            {
                return (sbyte**)((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->components;
            }

            set
            {
                ((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->components = (global::System.IntPtr)value;
            }
        }

        public sbyte** Labels
        {
            get
            {
                return (sbyte**)((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->labels;
            }

            set
            {
                ((global::LibPostalNet.LibpostalAddressParserResponse.__Internal*)__Instance)->labels = (global::System.IntPtr)value;
            }
        }
    }

    public unsafe partial class LibpostalAddressParserOptions : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr language;

            [FieldOffset(8)]
            internal global::System.IntPtr country;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0libpostal_address_parser_options@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalAddressParserOptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibPostalNet.LibpostalAddressParserOptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::LibPostalNet.LibpostalAddressParserOptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalAddressParserOptions(native.ToPointer(), skipVTables);
        }

        internal static global::LibPostalNet.LibpostalAddressParserOptions __CreateInstance(global::LibPostalNet.LibpostalAddressParserOptions.__Internal native, bool skipVTables = false)
        {
            return new global::LibPostalNet.LibpostalAddressParserOptions(native, skipVTables);
        }

        private static void* __CopyValue(global::LibPostalNet.LibpostalAddressParserOptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserOptions.__Internal));
            *(global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private LibpostalAddressParserOptions(global::LibPostalNet.LibpostalAddressParserOptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LibpostalAddressParserOptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LibpostalAddressParserOptions()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserOptions.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LibpostalAddressParserOptions(global::LibPostalNet.LibpostalAddressParserOptions _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LibPostalNet.LibpostalAddressParserOptions.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)__Instance) = *((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)_0.__Instance);
        }

        ~LibpostalAddressParserOptions()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::LibPostalNet.LibpostalAddressParserOptions __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public string Language
        {
            get
            {
                return Marshal.PtrToStringAnsi(((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)__Instance)->language);
            }

            set
            {
                ((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)__Instance)->language = Marshal.StringToHGlobalAnsi(value);
            }
        }

        public string Country
        {
            get
            {
                return Marshal.PtrToStringAnsi(((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)__Instance)->country);
            }

            set
            {
                ((global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)__Instance)->country = Marshal.StringToHGlobalAnsi(value);
            }
        }
    }

    public unsafe partial class libpostal
    {

        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_get_default_options")]
            internal static extern void LibpostalGetDefaultOptions(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_expand_address")]
            internal static extern sbyte** LibpostalExpandAddress([MarshalAs(UnmanagedType.LPStr)] string input, global::LibPostalNet.LibpostalNormalizeOptions.__Internal options, ulong* n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_expansion_array_destroy")]
            internal static extern void LibpostalExpansionArrayDestroy(sbyte** expansions, ulong n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_address_parser_response_destroy")]
            internal static extern void LibpostalAddressParserResponseDestroy(global::System.IntPtr self);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_get_address_parser_default_options")]
            internal static extern void LibpostalGetAddressParserDefaultOptions(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_parse_address")]
            internal static extern global::System.IntPtr LibpostalParseAddress([MarshalAs(UnmanagedType.LPStr)] string address, global::LibPostalNet.LibpostalAddressParserOptions.__Internal options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetup();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup_datadir")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetupDatadir([MarshalAs(UnmanagedType.LPStr)] string datadir);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_teardown")]
            internal static extern void LibpostalTeardown();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup_parser")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetupParser();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup_parser_datadir")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetupParserDatadir([MarshalAs(UnmanagedType.LPStr)] string datadir);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_teardown_parser")]
            internal static extern void LibpostalTeardownParser();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup_language_classifier")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetupLanguageClassifier();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_setup_language_classifier_datadir")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibpostalSetupLanguageClassifierDatadir([MarshalAs(UnmanagedType.LPStr)] string datadir);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("postal", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "libpostal_teardown_language_classifier")]
            internal static extern void LibpostalTeardownLanguageClassifier();
        }

        public static global::LibPostalNet.LibpostalNormalizeOptions LibpostalGetDefaultOptions()
        {
            var __ret = new global::LibPostalNet.LibpostalNormalizeOptions.__Internal();
            __Internal.LibpostalGetDefaultOptions(new IntPtr(&__ret));
            return global::LibPostalNet.LibpostalNormalizeOptions.__CreateInstance(__ret);
        }

        public static global::LibPostalNet.LibpostalNormalizeResponse LibpostalExpandAddress(string input, global::LibPostalNet.LibpostalNormalizeOptions options)
        {
            var __arg1 = ReferenceEquals(options, null) ? new global::LibPostalNet.LibpostalNormalizeOptions.__Internal() : *(global::LibPostalNet.LibpostalNormalizeOptions.__Internal*)options.__Instance;
            var __arg2 = new ulong();
            var __ret = __Internal.LibpostalExpandAddress(input, __arg1, &__arg2);
            global::LibPostalNet.LibpostalNormalizeResponse __result0;
            if (__arg2 == (ulong)0) __result0 = null;
            __result0 = global::LibPostalNet.LibpostalNormalizeResponse.__CreateInstance(__ret, __arg2);
            return __result0;
            
        }

        public static void LibpostalExpansionArrayDestroy(sbyte** expansions, ulong n)
        {
            __Internal.LibpostalExpansionArrayDestroy(expansions, n);
        }

        public static void LibpostalAddressParserResponseDestroy(global::LibPostalNet.LibpostalAddressParserResponse self)
        {
            var __arg0 = ReferenceEquals(self, null) ? global::System.IntPtr.Zero : self.__Instance;
            __Internal.LibpostalAddressParserResponseDestroy(__arg0);
        }

        public static global::LibPostalNet.LibpostalAddressParserOptions LibpostalGetAddressParserDefaultOptions()
        {
            var __ret = new global::LibPostalNet.LibpostalAddressParserOptions.__Internal();
            __Internal.LibpostalGetAddressParserDefaultOptions(new IntPtr(&__ret));
            return global::LibPostalNet.LibpostalAddressParserOptions.__CreateInstance(__ret);
        }

        public static global::LibPostalNet.LibpostalAddressParserResponse LibpostalParseAddress(string address, global::LibPostalNet.LibpostalAddressParserOptions options)
        {
            var __arg1 = ReferenceEquals(options, null) ? new global::LibPostalNet.LibpostalAddressParserOptions.__Internal() : *(global::LibPostalNet.LibpostalAddressParserOptions.__Internal*)options.__Instance;
            var __ret = __Internal.LibpostalParseAddress(address, __arg1);
            global::LibPostalNet.LibpostalAddressParserResponse __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::LibPostalNet.LibpostalAddressParserResponse.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::LibPostalNet.LibpostalAddressParserResponse)global::LibPostalNet.LibpostalAddressParserResponse.NativeToManagedMap[__ret];
            else __result0 = global::LibPostalNet.LibpostalAddressParserResponse.__CreateInstance(__ret);
            return __result0;
        }

        public static bool LibpostalSetup()
        {
            var __ret = __Internal.LibpostalSetup();
            return __ret;
        }

        public static bool LibpostalSetupDatadir(string datadir)
        {
            var __ret = __Internal.LibpostalSetupDatadir(datadir);
            return __ret;
        }

        public static void LibpostalTeardown()
        {
            __Internal.LibpostalTeardown();
        }

        public static bool LibpostalSetupParser()
        {
            var __ret = __Internal.LibpostalSetupParser();
            return __ret;
        }

        public static bool LibpostalSetupParserDatadir(string datadir)
        {
            var __ret = __Internal.LibpostalSetupParserDatadir(datadir);
            return __ret;
        }

        public static void LibpostalTeardownParser()
        {
            __Internal.LibpostalTeardownParser();
        }

        public static bool LibpostalSetupLanguageClassifier()
        {
            var __ret = __Internal.LibpostalSetupLanguageClassifier();
            return __ret;
        }

        public static bool LibpostalSetupLanguageClassifierDatadir(string datadir)
        {
            var __ret = __Internal.LibpostalSetupLanguageClassifierDatadir(datadir);
            return __ret;
        }

        public static void LibpostalTeardownLanguageClassifier()
        {
            __Internal.LibpostalTeardownLanguageClassifier();
        }
    }
}
