package hermanhawk.qian;

public class Role {
	/** ��Ϸ��ɫ����������*/
	public String name;
	/**�ȼ�*/
	public int level;
	/**ְҵ*/
	public String job;
	/**����*/
	public void doSkill(){
		if(name.equals("����")){
			System.out.println("�����ľ��似�ܣ�˫ǹ");
		}else if(name.equals("�����")){
			System.out.println("�԰�����һ��");
		}else{
			System.out.println("������������");
		}
	}
}
