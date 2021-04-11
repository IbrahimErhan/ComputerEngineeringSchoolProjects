library verilog;
use verilog.vl_types.all;
entity ShiftFunction_vlg_sample_tst is
    port(
        A               : in     vl_logic_vector(3 downto 0);
        Clock           : in     vl_logic;
        Right0Left1     : in     vl_logic;
        sampler_tx      : out    vl_logic
    );
end ShiftFunction_vlg_sample_tst;
