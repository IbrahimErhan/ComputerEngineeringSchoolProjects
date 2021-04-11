library verilog;
use verilog.vl_types.all;
entity Common_Bus_System_vlg_sample_tst is
    port(
        CLK             : in     vl_logic;
        CLR             : in     vl_logic_vector(3 downto 0);
        DataIn          : in     vl_logic_vector(3 downto 0);
        INR             : in     vl_logic_vector(3 downto 0);
        LD              : in     vl_logic_vector(3 downto 0);
        m               : in     vl_logic;
        RW              : in     vl_logic;
        S               : in     vl_logic_vector(2 downto 0);
        sampler_tx      : out    vl_logic
    );
end Common_Bus_System_vlg_sample_tst;
