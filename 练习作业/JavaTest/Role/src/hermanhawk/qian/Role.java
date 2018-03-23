package hermanhawk.qian;

public class Role {
	/** 游戏角色的名称属性*/
	public String name;
	/**等级*/
	public int level;
	/**职业*/
	public String job;
	/**技能*/
	public void doSkill(){
		if(name.equals("劳拉")){
			System.out.println("劳拉的经典技能：双枪");
		}else if(name.equals("孙悟空")){
			System.out.println("吃俺老孙一棒");
		}else{
			System.out.println("好厉害的样子");
		}
	}
}
