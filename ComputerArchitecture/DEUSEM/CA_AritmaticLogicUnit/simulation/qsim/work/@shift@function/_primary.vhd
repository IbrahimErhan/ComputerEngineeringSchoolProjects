library verilog;
use verilog.vl_types.all;
entity ShiftFunction is
    port(
        H               : out    vl_logic_vector(3 downto 0);
        A               : in     vl_logic_vector(3 downto 0);
        Clock           : in     vl_logic;
        Right1Left0     : in     vl_logic
    );
end ShiftFunction;
