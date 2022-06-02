using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateSkill_characters
    {
        public int characterId;
        public int skillId;

        public CreateSkill_characters(int CharacterId, int SkillId)
        {
            characterId = CharacterId;
            skillId = SkillId;
        }
    }

    public class Skill_characters
    {
        private int characterId;
        private int skillId;


        public Skill_characters(int CharacterId, int SkillId)
        {
            characterId = CharacterId;
            skillId = SkillId;
        }

        public int CharacterId
        {
            get
            {
                return characterId;
            }
            set
            {
                characterId = value;
            }
        }
        public int SkillId
        {
            get
            {
                return skillId;
            }
            set
            {
                skillId = value;
            }
        }
    }
}
