using system;
using wolfai;
using bhor_core;
using bhor_core.GENQY;

public class main_vb {
    static string coin_ { get; set; }
	static GENQY.GEN_LOADR ldl = new GENQY.GEN_LOADER("ADDR::0x0000b456j8");
	
	public main_vb() {
	   ldl.start();
	   ldl.reset_storage();
	   ldl.run_banner();
	}
	
}