
package inspec.ideas.trevorisation;

@net.sf.jni4net.attributes.ClrType
public class OrganisationSplit extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected OrganisationSplit(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public OrganisationSplit() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        inspec.ideas.trevorisation.OrganisationSplit.__ctorOrganisationSplit0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorOrganisationSplit0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LInspec/Ideas/Trevorisation/OrganisationSplit+Organisation;")
    public native static system.ValueType SplitOrganisation(java.lang.String rawData);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/String;")
    public native static java.lang.String LoseUnwantedSpaces(java.lang.String sText);
    
    public static system.Type typeof() {
        return inspec.ideas.trevorisation.OrganisationSplit.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        inspec.ideas.trevorisation.OrganisationSplit.staticType = staticType;
    }
    //</generated-proxy>
}
