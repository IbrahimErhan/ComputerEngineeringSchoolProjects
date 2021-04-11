library verilog;
use verilog.vl_types.all;
entity Common_Bus_System is
    port(
        data            : out    vl_logic_vector(3 downto 0);
        Clock1x         : in     vl_logic;
        DataIn          : in     vl_logic_vector(3 downto 0);
        Clock2x         : in     vl_logic;
        DataOut         : out    vl_logic_vector(3 downto 0);
        IR_input        : out    vl_logic_vector(10 downto 0)
    );
end Common_Bus_System;
