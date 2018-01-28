// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof (OrleansGeneratedCode.OrleansCodeGen46f05a9c61FeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"GrainInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Generated8D56680F0B826E8
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (IEmployee))]
    internal class OrleansCodeGenEmployeeReference : global::Orleans.Runtime.GrainReference, IEmployee
    {
        protected OrleansCodeGenEmployeeReference(global::Orleans.Runtime.GrainReference other): base (other)
        {
        }

        OrleansCodeGenEmployeeReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base (other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenEmployeeReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base (info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return -905325926;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"IEmployee";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == -905325926;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case -905325926:
                    switch (methodId)
                    {
                        case 312402437:
                            return @"GetLevel";
                        case 914577644:
                            return @"Promote";
                        case 940043127:
                            return @"GetManager";
                        case -1471658591:
                            return @"SetManager";
                        case -422726115:
                            return @"Greeting";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -905325926 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> GetLevel()
        {
            return base.InvokeMethodAsync<global::System.Int32>(312402437, null);
        }

        public global::System.Threading.Tasks.Task Promote(global::System.Int32 newLevel)
        {
            return base.InvokeMethodAsync<global::System.Object>(914577644, new global::System.Object[]{newLevel});
        }

        public global::System.Threading.Tasks.Task<IManager> GetManager()
        {
            return base.InvokeMethodAsync<IManager>(940043127, null);
        }

        public global::System.Threading.Tasks.Task SetManager(IManager manager)
        {
            return base.InvokeMethodAsync<global::System.Object>(-1471658591, new global::System.Object[]{manager is global::Orleans.Grain ? manager.AsReference<IManager>() : manager});
        }

        public global::System.Threading.Tasks.Task Greeting(GreetingData data)
        {
            return base.InvokeMethodAsync<global::System.Object>(-422726115, new global::System.Object[]{data});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (IEmployee), -905325926), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenEmployeeMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case -905325926:
                    switch (methodId)
                    {
                        case 312402437:
                            return await ((IEmployee)grain).GetLevel();
                        case 914577644:
                            await ((IEmployee)grain).Promote((global::System.Int32)arguments[0]);
                            return null;
                        case 940043127:
                            return await ((IEmployee)grain).GetManager();
                        case -1471658591:
                            await ((IEmployee)grain).SetManager((IManager)arguments[0]);
                            return null;
                        case -422726115:
                            await ((IEmployee)grain).Greeting((GreetingData)arguments[0]);
                            return null;
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -905325926 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -905325926;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace Generated8D56680F0B894DE
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (IHello))]
    internal class OrleansCodeGenHelloReference : global::Orleans.Runtime.GrainReference, IHello
    {
        protected OrleansCodeGenHelloReference(global::Orleans.Runtime.GrainReference other): base (other)
        {
        }

        OrleansCodeGenHelloReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base (other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenHelloReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base (info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return 1509201949;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"IHello";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == 1509201949;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case 1509201949:
                    switch (methodId)
                    {
                        case 2110985857:
                            return @"SayHello";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1509201949 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> SayHello(global::System.String msg)
        {
            return base.InvokeMethodAsync<global::System.String>(2110985857, new global::System.Object[]{msg});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (IHello), 1509201949), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenHelloMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case 1509201949:
                    switch (methodId)
                    {
                        case 2110985857:
                            return await ((IHello)grain).SayHello((global::System.String)arguments[0]);
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1509201949 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1509201949;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace Generated8D56680F0B8959C
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (IManager))]
    internal class OrleansCodeGenManagerReference : global::Orleans.Runtime.GrainReference, IManager
    {
        protected OrleansCodeGenManagerReference(global::Orleans.Runtime.GrainReference other): base (other)
        {
        }

        OrleansCodeGenManagerReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base (other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenManagerReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base (info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return -841853426;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"IManager";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == -841853426;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case -841853426:
                    switch (methodId)
                    {
                        case -1701259070:
                            return @"AsEmployee";
                        case -675836216:
                            return @"GetDirectReports";
                        case 807841091:
                            return @"AddDirectReport";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -841853426 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<IEmployee> AsEmployee()
        {
            return base.InvokeMethodAsync<IEmployee>(-1701259070, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<IEmployee>> GetDirectReports()
        {
            return base.InvokeMethodAsync<global::System.Collections.Generic.List<IEmployee>>(-675836216, null);
        }

        public global::System.Threading.Tasks.Task AddDirectReport(IEmployee employee)
        {
            return base.InvokeMethodAsync<global::System.Object>(807841091, new global::System.Object[]{employee is global::Orleans.Grain ? employee.AsReference<IEmployee>() : employee});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (IManager), -841853426), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case -841853426:
                    switch (methodId)
                    {
                        case -1701259070:
                            return await ((IManager)grain).AsEmployee();
                        case -675836216:
                            return await ((IManager)grain).GetDirectReports();
                        case 807841091:
                            await ((IManager)grain).AddDirectReport((IEmployee)arguments[0]);
                            return null;
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -841853426 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -841853426;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace Generated8D56680F0B895B0
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (IStockGrain))]
    internal class OrleansCodeGenStockGrainReference : global::Orleans.Runtime.GrainReference, IStockGrain
    {
        protected OrleansCodeGenStockGrainReference(global::Orleans.Runtime.GrainReference other): base (other)
        {
        }

        OrleansCodeGenStockGrainReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base (other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenStockGrainReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base (info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return 1335296891;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"IStockGrain";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == 1335296891 || interfaceId == -1277021679;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case 1335296891:
                    switch (methodId)
                    {
                        case 742617130:
                            return @"GetPrice";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1335296891 + @",methodId=" + methodId);
                    }

                case -1277021679:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -1277021679 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> GetPrice()
        {
            return base.InvokeMethodAsync<global::System.String>(742617130, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof (IStockGrain), 1335296891), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStockGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case 1335296891:
                    switch (methodId)
                    {
                        case 742617130:
                            return await ((IStockGrain)grain).GetPrice();
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1335296891 + @",methodId=" + methodId);
                    }

                case -1277021679:
                    switch (methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -1277021679 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1335296891;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace OrleansGeneratedCode192E1EB5
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (GreetingData))]
    internal sealed class OrleansCodeGenGreetingDataSerializer
    {
        public OrleansCodeGenGreetingDataSerializer(global::Orleans.Serialization.IFieldUtils fieldUtils)
        {
        }

        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            // No deep copy required since GreetingData is marked with the [Immutable] attribute.
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            GreetingData input = (GreetingData)untypedInput;
            context.SerializeInner(input.Count, typeof (global::System.Int32));
            context.SerializeInner(input.From, typeof (global::System.Guid));
            context.SerializeInner(input.Message, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            GreetingData result = new GreetingData();
            context.RecordObject(result);
            result.Count = (global::System.Int32)context.DeserializeInner(typeof (global::System.Int32));
            result.From = (global::System.Guid)context.DeserializeInner(typeof (global::System.Guid));
            result.Message = (global::System.String)context.DeserializeInner(typeof (global::System.String));
            return (GreetingData)result;
        }
    }
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGen46f05a9c61FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof (IEmployee), typeof (Generated8D56680F0B826E8.OrleansCodeGenEmployeeReference), typeof (Generated8D56680F0B826E8.OrleansCodeGenEmployeeMethodInvoker), -905325926));
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof (IHello), typeof (Generated8D56680F0B894DE.OrleansCodeGenHelloReference), typeof (Generated8D56680F0B894DE.OrleansCodeGenHelloMethodInvoker), 1509201949));
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof (IManager), typeof (Generated8D56680F0B8959C.OrleansCodeGenManagerReference), typeof (Generated8D56680F0B8959C.OrleansCodeGenManagerMethodInvoker), -841853426));
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof (IStockGrain), typeof (Generated8D56680F0B895B0.OrleansCodeGenStockGrainReference), typeof (Generated8D56680F0B895B0.OrleansCodeGenStockGrainMethodInvoker), 1335296891));
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddSerializerType(typeof (GreetingData), typeof (OrleansGeneratedCode192E1EB5.OrleansCodeGenGreetingDataSerializer));
            feature.AddKnownType(@"GreetingData,GrainInterfaces", @"GreetingData");
            feature.AddKnownType(@"IEmployee,GrainInterfaces", @"IEmployee");
            feature.AddKnownType(@"IHello,GrainInterfaces", @"IHello");
            feature.AddKnownType(@"IManager,GrainInterfaces", @"IManager");
            feature.AddKnownType(@"IStockGrain,GrainInterfaces", @"IStockGrain");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
