
namespace Chip8Core{
    
    public enum Instruction{
        //notes: Instruction names as suggested by source: http://devernay.free.fr/hacks/chip8/C8TECH10.HTM

        //TODO: Add documentation
        SYS_addr,
        CLS,
        RET,
        JP_addr,
        CALL_addr,
        SE_Vx_byte,
        SNE_Vx_byte,
        SE_Vx_Vy,
        LD_Vx_byte,
        ADD_Vx_byte,
        LD_Vx_Vy,
        OR_Vx_Vy,
        AND_Vx_Vy,
        XOR_Vx_Vy,
        ADD_Vx_Vy,
        SUB_Vx_Vy,
        SHR_Vx_Vy,
        SHL_Vx_Vy,
        SNE_Vx_Vy,
        LD_I_addr,
        JP_V0_addr,
        RND_Vx_byte,
        DRW_Vx_Vy_nibble,
        SKP_Vx,
        SKNP_Vx,
        LD_Vx_DT,
        LD_Vx_K,
        LD_DT_Vx,
        LD_ST_Vx,
        ADD_I_Vx,
        LD_F_Vx,
        LD_B_Vx,
        LD_I_Vx,
        LD_Vx_I,
    }
    
}
