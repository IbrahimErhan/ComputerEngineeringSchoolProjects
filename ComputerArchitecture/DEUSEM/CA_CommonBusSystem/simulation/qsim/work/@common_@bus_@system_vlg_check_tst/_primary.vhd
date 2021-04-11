library verilog;
use verilog.vl_types.all;
entity Common_Bus_System_vlg_check_tst is
    port(
        DataOut         : in     vl_logic_vector(3 downto 0);
        result          : in     vl_logic_vector(3 downto 0);
        sampler_rx      : in     vl_logic
    );
end Common_Bus_System_vlg_check_tst;
