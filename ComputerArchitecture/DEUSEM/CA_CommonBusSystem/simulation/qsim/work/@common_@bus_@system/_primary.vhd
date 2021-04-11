library verilog;
use verilog.vl_types.all;
entity Common_Bus_System is
    port(
        DataOut         : out    vl_logic_vector(3 downto 0);
        CLK             : in     vl_logic;
        INR             : in     vl_logic_vector(3 downto 0);
        LD              : in     vl_logic_vector(3 downto 0);
        result          : out    vl_logic_vector(3 downto 0);
        RW              : in     vl_logic;
        m               : in     vl_logic;
        CLR             : in     vl_logic_vector(3 downto 0);
        DataIn          : in     vl_logic_vector(3 downto 0);
        S               : in     vl_logic_vector(2 downto 0)
    );
end Common_Bus_System;
