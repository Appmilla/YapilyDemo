namespace Appmilla.Yapily.Refit.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.26.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PaymentEmbeddedAuthorisationRequestResponseStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_AUTHORIZATION")]
        AWAITING_AUTHORIZATION = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_FURTHER_AUTHORIZATION")]
        AWAITING_FURTHER_AUTHORIZATION = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_RE_AUTHORIZATION")]
        AWAITING_RE_AUTHORIZATION = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"AUTHORIZED")]
        AUTHORIZED = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"CONSUMED")]
        CONSUMED = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"REJECTED")]
        REJECTED = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"REVOKED")]
        REVOKED = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"FAILED")]
        FAILED = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"EXPIRED")]
        EXPIRED = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"INVALID")]
        INVALID = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_PRE_AUTHORIZATION")]
        AWAITING_PRE_AUTHORIZATION = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_DECOUPLED_PRE_AUTHORIZATION")]
        AWAITING_DECOUPLED_PRE_AUTHORIZATION = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"PRE_AUTHORIZED")]
        PRE_AUTHORIZED = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_DECOUPLED_AUTHORIZATION")]
        AWAITING_DECOUPLED_AUTHORIZATION = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_SCA_METHOD")]
        AWAITING_SCA_METHOD = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"AWAITING_SCA_CODE")]
        AWAITING_SCA_CODE = 16,

    }
}