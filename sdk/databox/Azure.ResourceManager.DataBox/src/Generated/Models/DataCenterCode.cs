// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> DataCenter code. </summary>
    public readonly partial struct DataCenterCode : IEquatable<DataCenterCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataCenterCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataCenterCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string BY2Value = "BY2";
        private const string BY1Value = "BY1";
        private const string ORK70Value = "ORK70";
        private const string AM2Value = "AM2";
        private const string AMS20Value = "AMS20";
        private const string BY21Value = "BY21";
        private const string BY24Value = "BY24";
        private const string MWH01Value = "MWH01";
        private const string AMS06Value = "AMS06";
        private const string SSE90Value = "SSE90";
        private const string SYD03Value = "SYD03";
        private const string SYD23Value = "SYD23";
        private const string CBR20Value = "CBR20";
        private const string YTO20Value = "YTO20";
        private const string CWL20Value = "CWL20";
        private const string LON24Value = "LON24";
        private const string BOM01Value = "BOM01";
        private const string BL20Value = "BL20";
        private const string BL7Value = "BL7";
        private const string SEL20Value = "SEL20";
        private const string TYO01Value = "TYO01";
        private const string BN1Value = "BN1";
        private const string SN5Value = "SN5";
        private const string CYS04Value = "CYS04";
        private const string TYO22Value = "TYO22";
        private const string YTO21Value = "YTO21";
        private const string YQB20Value = "YQB20";
        private const string FRA22Value = "FRA22";
        private const string MAA01Value = "MAA01";
        private const string CPQ02Value = "CPQ02";
        private const string CPQ20Value = "CPQ20";
        private const string SIN20Value = "SIN20";
        private const string HKG20Value = "HKG20";
        private const string SG2Value = "SG2";
        private const string MEL23Value = "MEL23";
        private const string SEL21Value = "SEL21";
        private const string OSA20Value = "OSA20";
        private const string SHA03Value = "SHA03";
        private const string BJBValue = "BJB";
        private const string JNB22Value = "JNB22";
        private const string JNB21Value = "JNB21";
        private const string MNZ21Value = "MNZ21";
        private const string SN8Value = "SN8";
        private const string AUH20Value = "AUH20";
        private const string ZRH20Value = "ZRH20";
        private const string PUS20Value = "PUS20";
        private const string AdHocValue = "AdHoc";
        private const string CH1Value = "CH1";
        private const string DSM05Value = "DSM05";
        private const string DUB07Value = "DUB07";
        private const string PNQ01Value = "PNQ01";
        private const string SVG20Value = "SVG20";
        private const string OSA02Value = "OSA02";
        private const string OSA22Value = "OSA22";
        private const string PAR22Value = "PAR22";
        private const string BN7Value = "BN7";
        private const string SN6Value = "SN6";
        private const string BJS20Value = "BJS20";
        private const string BL24Value = "BL24";
        private const string IdC5Value = "IDC5";
        private const string TYO23Value = "TYO23";
        private const string CPQ21Value = "CPQ21";
        private const string NTG20Value = "NTG20";
        private const string DXB23Value = "DXB23";
        private const string DSM11Value = "DSM11";
        private const string OSA23Value = "OSA23";
        private const string AMS25Value = "AMS25";

        /// <summary> Invalid. </summary>
        public static DataCenterCode Invalid { get; } = new DataCenterCode(InvalidValue);
        /// <summary> BY2. </summary>
        public static DataCenterCode BY2 { get; } = new DataCenterCode(BY2Value);
        /// <summary> BY1. </summary>
        public static DataCenterCode BY1 { get; } = new DataCenterCode(BY1Value);
        /// <summary> ORK70. </summary>
        public static DataCenterCode ORK70 { get; } = new DataCenterCode(ORK70Value);
        /// <summary> AM2. </summary>
        public static DataCenterCode AM2 { get; } = new DataCenterCode(AM2Value);
        /// <summary> AMS20. </summary>
        public static DataCenterCode AMS20 { get; } = new DataCenterCode(AMS20Value);
        /// <summary> BY21. </summary>
        public static DataCenterCode BY21 { get; } = new DataCenterCode(BY21Value);
        /// <summary> BY24. </summary>
        public static DataCenterCode BY24 { get; } = new DataCenterCode(BY24Value);
        /// <summary> MWH01. </summary>
        public static DataCenterCode MWH01 { get; } = new DataCenterCode(MWH01Value);
        /// <summary> AMS06. </summary>
        public static DataCenterCode AMS06 { get; } = new DataCenterCode(AMS06Value);
        /// <summary> SSE90. </summary>
        public static DataCenterCode SSE90 { get; } = new DataCenterCode(SSE90Value);
        /// <summary> SYD03. </summary>
        public static DataCenterCode SYD03 { get; } = new DataCenterCode(SYD03Value);
        /// <summary> SYD23. </summary>
        public static DataCenterCode SYD23 { get; } = new DataCenterCode(SYD23Value);
        /// <summary> CBR20. </summary>
        public static DataCenterCode CBR20 { get; } = new DataCenterCode(CBR20Value);
        /// <summary> YTO20. </summary>
        public static DataCenterCode YTO20 { get; } = new DataCenterCode(YTO20Value);
        /// <summary> CWL20. </summary>
        public static DataCenterCode CWL20 { get; } = new DataCenterCode(CWL20Value);
        /// <summary> LON24. </summary>
        public static DataCenterCode LON24 { get; } = new DataCenterCode(LON24Value);
        /// <summary> BOM01. </summary>
        public static DataCenterCode BOM01 { get; } = new DataCenterCode(BOM01Value);
        /// <summary> BL20. </summary>
        public static DataCenterCode BL20 { get; } = new DataCenterCode(BL20Value);
        /// <summary> BL7. </summary>
        public static DataCenterCode BL7 { get; } = new DataCenterCode(BL7Value);
        /// <summary> SEL20. </summary>
        public static DataCenterCode SEL20 { get; } = new DataCenterCode(SEL20Value);
        /// <summary> TYO01. </summary>
        public static DataCenterCode TYO01 { get; } = new DataCenterCode(TYO01Value);
        /// <summary> BN1. </summary>
        public static DataCenterCode BN1 { get; } = new DataCenterCode(BN1Value);
        /// <summary> SN5. </summary>
        public static DataCenterCode SN5 { get; } = new DataCenterCode(SN5Value);
        /// <summary> CYS04. </summary>
        public static DataCenterCode CYS04 { get; } = new DataCenterCode(CYS04Value);
        /// <summary> TYO22. </summary>
        public static DataCenterCode TYO22 { get; } = new DataCenterCode(TYO22Value);
        /// <summary> YTO21. </summary>
        public static DataCenterCode YTO21 { get; } = new DataCenterCode(YTO21Value);
        /// <summary> YQB20. </summary>
        public static DataCenterCode YQB20 { get; } = new DataCenterCode(YQB20Value);
        /// <summary> FRA22. </summary>
        public static DataCenterCode FRA22 { get; } = new DataCenterCode(FRA22Value);
        /// <summary> MAA01. </summary>
        public static DataCenterCode MAA01 { get; } = new DataCenterCode(MAA01Value);
        /// <summary> CPQ02. </summary>
        public static DataCenterCode CPQ02 { get; } = new DataCenterCode(CPQ02Value);
        /// <summary> CPQ20. </summary>
        public static DataCenterCode CPQ20 { get; } = new DataCenterCode(CPQ20Value);
        /// <summary> SIN20. </summary>
        public static DataCenterCode SIN20 { get; } = new DataCenterCode(SIN20Value);
        /// <summary> HKG20. </summary>
        public static DataCenterCode HKG20 { get; } = new DataCenterCode(HKG20Value);
        /// <summary> SG2. </summary>
        public static DataCenterCode SG2 { get; } = new DataCenterCode(SG2Value);
        /// <summary> MEL23. </summary>
        public static DataCenterCode MEL23 { get; } = new DataCenterCode(MEL23Value);
        /// <summary> SEL21. </summary>
        public static DataCenterCode SEL21 { get; } = new DataCenterCode(SEL21Value);
        /// <summary> OSA20. </summary>
        public static DataCenterCode OSA20 { get; } = new DataCenterCode(OSA20Value);
        /// <summary> SHA03. </summary>
        public static DataCenterCode SHA03 { get; } = new DataCenterCode(SHA03Value);
        /// <summary> BJB. </summary>
        public static DataCenterCode BJB { get; } = new DataCenterCode(BJBValue);
        /// <summary> JNB22. </summary>
        public static DataCenterCode JNB22 { get; } = new DataCenterCode(JNB22Value);
        /// <summary> JNB21. </summary>
        public static DataCenterCode JNB21 { get; } = new DataCenterCode(JNB21Value);
        /// <summary> MNZ21. </summary>
        public static DataCenterCode MNZ21 { get; } = new DataCenterCode(MNZ21Value);
        /// <summary> SN8. </summary>
        public static DataCenterCode SN8 { get; } = new DataCenterCode(SN8Value);
        /// <summary> AUH20. </summary>
        public static DataCenterCode AUH20 { get; } = new DataCenterCode(AUH20Value);
        /// <summary> ZRH20. </summary>
        public static DataCenterCode ZRH20 { get; } = new DataCenterCode(ZRH20Value);
        /// <summary> PUS20. </summary>
        public static DataCenterCode PUS20 { get; } = new DataCenterCode(PUS20Value);
        /// <summary> AdHoc. </summary>
        public static DataCenterCode AdHoc { get; } = new DataCenterCode(AdHocValue);
        /// <summary> CH1. </summary>
        public static DataCenterCode CH1 { get; } = new DataCenterCode(CH1Value);
        /// <summary> DSM05. </summary>
        public static DataCenterCode DSM05 { get; } = new DataCenterCode(DSM05Value);
        /// <summary> DUB07. </summary>
        public static DataCenterCode DUB07 { get; } = new DataCenterCode(DUB07Value);
        /// <summary> PNQ01. </summary>
        public static DataCenterCode PNQ01 { get; } = new DataCenterCode(PNQ01Value);
        /// <summary> SVG20. </summary>
        public static DataCenterCode SVG20 { get; } = new DataCenterCode(SVG20Value);
        /// <summary> OSA02. </summary>
        public static DataCenterCode OSA02 { get; } = new DataCenterCode(OSA02Value);
        /// <summary> OSA22. </summary>
        public static DataCenterCode OSA22 { get; } = new DataCenterCode(OSA22Value);
        /// <summary> PAR22. </summary>
        public static DataCenterCode PAR22 { get; } = new DataCenterCode(PAR22Value);
        /// <summary> BN7. </summary>
        public static DataCenterCode BN7 { get; } = new DataCenterCode(BN7Value);
        /// <summary> SN6. </summary>
        public static DataCenterCode SN6 { get; } = new DataCenterCode(SN6Value);
        /// <summary> BJS20. </summary>
        public static DataCenterCode BJS20 { get; } = new DataCenterCode(BJS20Value);
        /// <summary> BL24. </summary>
        public static DataCenterCode BL24 { get; } = new DataCenterCode(BL24Value);
        /// <summary> IDC5. </summary>
        public static DataCenterCode IdC5 { get; } = new DataCenterCode(IdC5Value);
        /// <summary> TYO23. </summary>
        public static DataCenterCode TYO23 { get; } = new DataCenterCode(TYO23Value);
        /// <summary> CPQ21. </summary>
        public static DataCenterCode CPQ21 { get; } = new DataCenterCode(CPQ21Value);
        /// <summary> NTG20. </summary>
        public static DataCenterCode NTG20 { get; } = new DataCenterCode(NTG20Value);
        /// <summary> DXB23. </summary>
        public static DataCenterCode DXB23 { get; } = new DataCenterCode(DXB23Value);
        /// <summary> DSM11. </summary>
        public static DataCenterCode DSM11 { get; } = new DataCenterCode(DSM11Value);
        /// <summary> OSA23. </summary>
        public static DataCenterCode OSA23 { get; } = new DataCenterCode(OSA23Value);
        /// <summary> AMS25. </summary>
        public static DataCenterCode AMS25 { get; } = new DataCenterCode(AMS25Value);
        /// <summary> Determines if two <see cref="DataCenterCode"/> values are the same. </summary>
        public static bool operator ==(DataCenterCode left, DataCenterCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataCenterCode"/> values are not the same. </summary>
        public static bool operator !=(DataCenterCode left, DataCenterCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataCenterCode"/>. </summary>
        public static implicit operator DataCenterCode(string value) => new DataCenterCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataCenterCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataCenterCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
