library verilog;
use verilog.vl_types.all;
entity ShiftFunction_vlg_check_tst is
    port(
        H               : in     vl_logic_vector(3 downto 0);
        sampler_rx      : in     vl_logic
    );
end ShiftFunction_vlg_check_tst;
