library verilog;
use verilog.vl_types.all;
entity ArithmaticLogicUnit_vlg_check_tst is
    port(
        E               : in     vl_logic;
        Output          : in     vl_logic_vector(3 downto 0);
        sampler_rx      : in     vl_logic
    );
end ArithmaticLogicUnit_vlg_check_tst;
