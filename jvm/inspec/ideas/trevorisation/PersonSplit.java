
package inspec.ideas.trevorisation;

@net.sf.jni4net.attributes.ClrType
public class PersonSplit extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected PersonSplit(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public PersonSplit() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        inspec.ideas.trevorisation.PersonSplit.__ctorPersonSplit0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorPersonSplit0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LInspec/Ideas/Trevorisation/PersonSplit+Person;")
    public native static system.ValueType SplitPerson(java.lang.String rawData);
    
    public static system.Type typeof() {
        return inspec.ideas.trevorisation.PersonSplit.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        inspec.ideas.trevorisation.PersonSplit.staticType = staticType;
    }
    //</generated-proxy>
}
