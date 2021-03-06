﻿using System;
using OneSpanSign.API;
using OneSpanSign.Sdk;
using OneSpanSign.Sdk.Builder;
using System.Collections.Generic;

namespace SDK.Examples
{
    public class SignerVerificationTypesExample : SDKSample
    {
        public IList<VerificationType> verificationTypes;

        public static void Main(string[] args)
        {
            new SignerVerificationExample().Run();
        }

        override public void Execute()
        {
            this.verificationTypes = ossClient.AccountService.getVerificationTypes();
        }
    }
}

