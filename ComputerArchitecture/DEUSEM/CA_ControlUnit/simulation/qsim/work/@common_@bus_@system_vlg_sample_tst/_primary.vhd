library verilog;
use verilog.vl_types.all;
entity Common_Bus_System_vlg_sample_tst is
    port(
        Clock1x         : in     vl_logic;
        Clock2x         : in     vl_logic;
        DataIn          : in     vl_logic_vector(3 downto 0);
        sampler_tx      : out    vl_logic
    );
end Common_Bus_System_vlg_sample_tst;
