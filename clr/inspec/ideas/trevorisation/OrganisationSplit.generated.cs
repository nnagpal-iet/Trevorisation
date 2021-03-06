
namespace Inspec.Ideas.Trevorisation {
    
    
    #region Component Designer generated code 
    public partial class OrganisationSplit_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::Inspec.Ideas.Trevorisation.@__OrganisationSplit.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::Inspec.Ideas.Trevorisation.OrganisationSplit), typeof(global::Inspec.Ideas.Trevorisation.OrganisationSplit_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::Inspec.Ideas.Trevorisation.OrganisationSplit), typeof(global::Inspec.Ideas.Trevorisation.OrganisationSplit_))]
    internal sealed partial class @__OrganisationSplit : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__OrganisationSplit(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::Inspec.Ideas.Trevorisation.@__OrganisationSplit.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__OrganisationSplit);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "SplitOrganisation", "SplitOrganisation0", "(Ljava/lang/String;)Lsystem/ValueType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "LoseUnwantedSpaces", "LoseUnwantedSpaces1", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorOrganisationSplit0", "__ctorOrganisationSplit0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle SplitOrganisation0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle rawData) {
            // (Ljava/lang/String;)Lsystem/ValueType;
            // (LSystem/String;)LInspec/Ideas/Trevorisation/OrganisationSplit+Organisation;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::Inspec.Ideas.Trevorisation.OrganisationSplit.Organisation>(@__env, global::Inspec.Ideas.Trevorisation.OrganisationSplit.SplitOrganisation(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, rawData)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle LoseUnwantedSpaces1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle sText) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, global::Inspec.Ideas.Trevorisation.OrganisationSplit.LoseUnwantedSpaces(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, sText)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorOrganisationSplit0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::Inspec.Ideas.Trevorisation.OrganisationSplit @__real = new global::Inspec.Ideas.Trevorisation.OrganisationSplit();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::Inspec.Ideas.Trevorisation.@__OrganisationSplit(@__env);
            }
        }
    }
    #endregion
}
