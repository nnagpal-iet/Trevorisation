
namespace Inspec.Ideas.Trevorisation {
    
    
    #region Component Designer generated code 
    public partial class Stemmer_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::Inspec.Ideas.Trevorisation.@__Stemmer.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::Inspec.Ideas.Trevorisation.Stemmer), typeof(global::Inspec.Ideas.Trevorisation.Stemmer_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::Inspec.Ideas.Trevorisation.Stemmer), typeof(global::Inspec.Ideas.Trevorisation.Stemmer_))]
    internal sealed partial class @__Stemmer : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Stemmer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::Inspec.Ideas.Trevorisation.@__Stemmer.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Stemmer);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMode", "Mode0", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setMode", "Mode1", "(Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetStem", "GetStem2", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorStemmer0", "__ctorStemmer0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorStemmer1", "__ctorStemmer1", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Enum;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Mode0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LInspec/Ideas/Trevorisation/Stemmer+StemmerMode;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::Inspec.Ideas.Trevorisation.Stemmer @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Inspec.Ideas.Trevorisation.Stemmer>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::Inspec.Ideas.Trevorisation.Stemmer.StemmerMode>(@__env, @__real.Mode);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Mode1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Enum;)V
            // (LInspec/Ideas/Trevorisation/Stemmer+StemmerMode;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::Inspec.Ideas.Trevorisation.Stemmer @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Inspec.Ideas.Trevorisation.Stemmer>(@__env, @__obj);
            @__real.Mode = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Inspec.Ideas.Trevorisation.Stemmer.StemmerMode>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetStem2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle term) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::Inspec.Ideas.Trevorisation.Stemmer @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Inspec.Ideas.Trevorisation.Stemmer>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, @__real.GetStem(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, term)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorStemmer0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::Inspec.Ideas.Trevorisation.Stemmer @__real = new global::Inspec.Ideas.Trevorisation.Stemmer();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void @__ctorStemmer1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle mode) {
            // (Lsystem/Enum;)V
            // (LInspec/Ideas/Trevorisation/Stemmer+StemmerMode;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::Inspec.Ideas.Trevorisation.Stemmer @__real = new global::Inspec.Ideas.Trevorisation.Stemmer(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::Inspec.Ideas.Trevorisation.Stemmer.StemmerMode>(@__env, mode));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::Inspec.Ideas.Trevorisation.@__Stemmer(@__env);
            }
        }
    }
    #endregion
}
