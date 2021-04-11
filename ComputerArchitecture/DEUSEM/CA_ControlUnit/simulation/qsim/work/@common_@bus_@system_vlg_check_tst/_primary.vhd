library verilog;
use verilog.vl_types.all;
entity Common_Bus_System_vlg_check_tst is
    port(
        data            : in     vl_logic_vector(3 downto 0);
        DataOut         : in     vl_logic_vector(3 downto 0);
        IR_input        : in     vl_logic_vector(10 downto 0);
        sampler_rx      : in     vl_logic
    );
end Common_Bus_System_vlg_check_tst;
