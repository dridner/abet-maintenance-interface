using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using AMI.Model.Util;
using Microsoft.AspNet.Identity;

namespace AMI.Data.SeedInformation
{
    public class ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            //newClass = CreateClass(context, systemUserAccount, "Computer Architecture and Organization", "EECS", "2110", "Write simple programs using assembly language to demonstrate an ability to manipulate data using CPU registers and memory.",
            //    "Understand modern computer architecture enhancements and be able to compare and contrast processors.",
            //    "Understand memory hierarchy, interrupts, and I/O systems and their importance and impact on CPU performance.",
            //    "Know and discuss the major features of RISC and CISC architectures.",
            //    "Understand how interrupts and I/O devices affect program execution and system performance.",
            //    "Design and develop a simple CISC microprocessor and its microcode to perform simple functions.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.Member);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Electric Circuits", "EECS", "2300", "Define voltage, current, energy and power in the context of an electric circuit.",
            //    "Define the terminal behavior of the basic linear circuit elements.",
            //    "Apply Kirchoff's laws to nodal and mesh analysis of a circuit.",
            //    "Apply Thevenin's and Norton's theorems to circuit analysis.",
            //    "Apply the voltage divider, current divider, superposition, and maximum-power transfer theorems to circuit analysis.",
            //    "Perform AC steady state circuit analysis using phasors.",
            //    "Calculate complex power in an AC system.",
            //    "Do transient analysis of first order circuits.",
            //    "Analyze circuits containing ideal op-amps.",
            //    "Recognize physical circuit elements in the lab and assemble a circuit from a schematic diagram.",
            //    "Experimentally measure voltage, current and power.",
            //    "Produce a written lab report in a standard format, which includes a brief discussion of relevant theory.",
            //    "Design and demonstrate an experimental process to make measurements such as on an unknown one-port network and derive Thevenin and Norton equivalents for the same.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "krishna.shenai", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Microsystem Design", "EECS", "3100", "Describe the meaning of an embedded system, the reasons for the importance of embedded systems, and how computer engineering uses or benefits from embedded systems.",
            //    "Understand how assembly language programs convert into executable code through assembler, linker, locator and loader for an embedded system environment.",
            //    "Write assembly code for an embedded system to function as system kernel, to perform setup, initialization, and built-in system testing.",
            //    "Understand role of modern computer engineering hardware and software tools in system development and how to use these tools to support the design methodology.",
            //    "Develop an understanding of the differences between a microprocessor and a microcontroller in regards to the hardware/software interface for communication with external devices.",
            //    "Design a memory subsystem with both read-only memory and random-access memory for a microprocessor, develop read-only memory compliant random-access memory testing program in relevant assembly language, and program read-only memory with the memory testing program.",
            //    "Design an interface for a programmable input/output device such as universal synchronous-asynchronous receiver-transmitter and develop the device driver code in assembly/machine language.",
            //    "Design an interface for a programmable interrupt controller and develop the code for device drivers in assembly/machine language.",
            //    "Prototype a minimal system complete with microprocessor, both read-onl and random-access memory, read-only memory resident random-access memory testing program, and system startup code developed in assembly or machine language.",
            //    "Function effectively on a multidisciplinary team (as potentially composed of EE and CSE majors), with effectiveness being determined by instructor observation, peer ratings, and self-assessment.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gursel.serpen", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Signals and Systems", "EECS", "3200", "Represent and classify signals and systems.",
            //    "Represent and apply singularity functions.",
            //    "Obtain the response of a continuous, linear, time-invariant, causal system by using convolution.",
            //    "Obtain the Fourier series expansion of a periodic signal and apply it to continuous, linear, time-invariant systems.",
            //    "Obtain and plot the Fourier transform for simple aperiodic continuous-time signals.",
            //    "Utilize the Laplace transform method to solve continuous, linear, time-invariant systems and to obtain transfer functions.",
            //    "Analyze continuous, linear time-invariant systems using state variable formulation and solve the resulting state equations.",
            //    "Convert a continuous-time signal to the discrete-time domain and reconstruct it using the sampling theorem.",
            //    "Utilize the z-transform method to solve linear discrete-time systems and to obtain transfer functions.",
            //    "Use MATLAB software to implement the signal processing and system analysis techniques taught in the course.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "ezzatollah.salari", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "weng.kang", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Probabilistic Methods for Engineering", "EECS", "3300", "Characterize probability models using probability mass function and probability density function for discrete and continuous random variables.",
            //    "Describe conditional and independent events and conditional random variables.",
            //    "Evaluate the mean and variance of different distributions.",
            //    "Calculate the cumulative distribution functions for both discrete and continuous random variables.",
            //    "Characterize functions of random variables.",
            //    "Characterize jointly multiple discrete and continuous random variables.",
            //    "Use computer software to generate probability distribution functions.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "ezzatollah.salari", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "jung.kim", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gerald.heuring", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Electronics I", "EECS", "3400", "Apply the large signal method of analysis to electronic circuits that contain nonlinear circuit elements: diodes, FETs and BJTs.",
            //    "Apply the SPICE simulation method of analysis to electronic circuits that contain nonlinear circuit elements: diodes, FETs and BJTs.",
            //    "Design FET and BJT inverter circuits with a required noise margin and fan-out, inverters of minimum size, with equal rise and fall times, and with specified logic threshold voltage value.",
            //    "Explain the tradeoffs for lowering power dissipation in digital electronic circuits.",
            //    "Analyze combinational logic circuits to determine the Boolean function implemented by the circuit.",
            //    "Design combinational static CMOS gates so that they implement a desired Boolean function, and to design the transistor aspect ratios so that the CMOS gate has the same rise and fall times as the reference inverter.",
            //    "Give examples of the three established principles of encoding the logic/numeric values in memory cells: by the state of a bistable circuit, by an electrical charge on a capacitance, and by a FET’s threshold voltage value.",
            //    "State the challenges and the complexity tradeoffs in the design of modern memory arrays.",
            //    "State the design principles used in legacy TTL and ECL integrated circuits.",
            //    "Conduct experiments in order to collect, analyze, and interpret data.",
            //    "Explain the properties of semiconductor materials and the mechanisms of charge transportation in the semiconductor materials.",
            //    "Design an experiment to measure the propagation delay of a representative two families of widely used digital logic gates (4xxx series CMOS and 74LSxx series TTL).",
            //    "Function effectively on a team with effectiveness being determined by as documented in lab reports, instructor observations, and peer ratings.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "anthony.johnson", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "weng.kang", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.Member);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "rashmi.jha", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Electronics II", "EECS", "3420", "Produce useful incremental models for MOSFET's and BJT's at midband and high frequency.",
            //    "Describe the properties of four basic analog amplifier topologies (CE, CB, CC, and differential pair).",
            //    "Produce useful incremental models for broadband analog amplifiers in their midband, low-frequency, and high-frequency regions.",
            //    "Calculate amplifier transfer functions, and input and output resistances.",
            //    "Calculate, interpret and communicate the low- and high-frequency response behaviors of broadband amplifiers using Bode plots and suitable approximations.",
            //    "Characterize the effects of midband negative feedback on broadband amplifiers at the system (block diagram) level.",
            //    "Identify and model the midband effects, including impedance modification, of series-series, shunt-shunt, shunt-series, and series-shunt negative feedback on broadband amplifiers.",
            //    "Succinctly state the basic concepts of the course using one or two sentences per concept.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "anthony.johnson", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "rashmi.jha", CommitteeRank.Member);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "krishna.shenai", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Electronics Lab", "EECS", "3440", "Experimentally measure incremental gains and resistances of analog amplifiers at midband.",
            //    "Experimentally measure and plot frequency response curves of analog amplifiers.",
            //    "Produce a written lab report in a standard format, which includes a brief discussion of relevant theory.",
            //    "Make meaningful evaluations of the degree of experimental correlation with the results of SPICE simulations and/or calculations based upon simplified models.",
            //    "Correctly use the basic analog laboratory instruments.");
            
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "anthony.johnson", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "rashmi.jha", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Energy Conversion", "EECS", "3460", "Understand the basic properties of magnetic materials and how to analyze magnetic circuits.",
            //    "Perform analysis of transformer models and applications.",
            //    "Understand fundamental concepts of rotating machines and use of energy and co-energy functions.",
            //    "Understand synchronous motors and generator analysis and applications.",
            //    "Understand basics of dc motors and generators and applications.",
            //    "Understand induction motor analysis and applications, both 3-phase and 1-phase.",
            //    "Learn the technical and socio-metric issues of operating the modern AC power grid.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "thomas.stuart", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.ViceChair);

            //newClass = CreateClass(context, systemUserAccount, "Energy Conversion Lab", "EECS", "3480", "Perform transformer connections and measure parameters.",
            //    "Measure machine parameters and understand operation.",
            //    "Understand synchronous machine operating principles and characteristics.",
            //    "Understand operating principles of different types of dc motors and applications.",
            //    "Understand operating principles of different types of dc generators and applications.",
            //    "Understand operating principles of different types of induction motors and applications.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "thomas.stuart", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.ViceChair);

            //newClass = CreateClass(context, systemUserAccount, "Electromagnetics", "EECS", "3700", "Learn/review the basics of harmonic waves and the phasor technique.",
            //    "Learn the basics of transmission lines (TL), Propagation of harmonic signals on TL, TL parameters and equations. Be able to apply the knowledge in basic analysis and design problems.",
            //    "Learn the basics of the Smith Chart as a tool for transmission line calculations. Be able to use the chart for basic parameter calculation and analysis of transmission lines.",
            //    "Learn/review vector algebra, vector analysis, and orthogonal coordinate systems basics. Be able to apply vectors in solving relevant problems.",
            //    "Learn/review important electrostatic concepts, such as Coulomb’s law, Gauss’ law, Maxwell’s equations, electric field boundary conditions, and electrostatic potential. Be able to apply these concepts in basic electric field and potential calculations.",
            //    "Learn/review the basics of materials and their electrical properties, as well as related concepts of resistance, capacitance, and electrostatic energy. Be able to apply this knowledge in basic analysis and design problems.",
            //    "Learn/review important magnetostatics concepts, such as magnetic forces and torques, Biot-Savart’s and Ampere’s laws, magnetic field boundary conditions and vector magnetic potential. Be able to apply these concepts in basic magnetic field and potential calculations.",
            //    "Learn/review the basics of materials and their magnetic properties, as well as related concepts of inductance and magnetic energy. Be able to apply this knowledge in basic analysis and design problems.",
            //    "Learn/review Maxwell’s equations for time-varying fields, and the related results and concepts such as Faraday’s law, electromagnetic induction, charge-current continuity relation, displacement current, and electromagnetic potentials. Be able to apply these concepts in basic calculations.",
            //    "Learn/review the basics of the materials electromagnetic properties, as well as the principles of transformers, electromagnetic generation and actuation and free-charge dissipation in conductors.",
            //    "Learn the basics of the electromagnetic wave propagation in free space as described by the Maxwell equations and the resulting wave equation.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "daniel.georgiev", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "vijay.devabhaktuni", CommitteeRank.ViceChair);

            //newClass = CreateClass(context,systemUserAccount, "Senior Design", "EECS", "4000", "Design a complex system (or component or process) to realistic performance specifications in compliance with applicable engineering standards.",
            //    "Build a prototype of a design and demonstrate that it meets performance specifications.",
            //    "List and discuss several possible reasons for deviations between predicted and measured results from an experiment or design, and choose the most likely reason and justify the choice.",
            //    "Identify the stages of team development and give examples of team behaviors that are characteristic of each stage.",
            //    "Summarize effective strategies for dealing with a variety of interpersonal and communication problems that commonly arise in teamwork, choose the best of several given strategies for a specified problem, and justify the choice.",
            //    "Function effectively on a team, with effectiveness being determined by instructor observation, peer ratings, and self-assessment.",
            //    "Explain aspects of a project, process, or product related to specified engineering and non-engineering disciplines.",
            //    "Given a job-related scenario that requires a decision with ethical implications, the student will be able to identify possible courses of action and discuss the pros and cons of each one, pick the best course of action and justify the decision.",
            //    "Write an effective technical correspondence (i.e. abstract, executive summary, project report) or give an effective oral presentation.",
            //    "Propose a solution or critique a proposed solution to an engineering problem, identifying possible global, societal, economic and environmental consequences and recommending ways to minimize or avoid them.",
            //    "Recognize the rapidly evolving nature of technological landscape in engineering and computer science and resulting need for continuous learning.",
            //    "Participate effectively in a team project and assess the strengths and weaknesses of the individual team members (including himself/herself) and the team as a unit.",
            //    "Identify important contemporary regional, national, or global socio-economic problems (such as global warming, over population, depletion of natural resources, energy and water supplied, nuclear waste, environmental pollution, trade, human rights, etc.) that involve engineering.",
            //    "Propose and discuss ways engineers are contributing or might contribute to the solution of specified regional, national, and global socio-economic problems (such as global warming, over population, depletion of natural resources, energy and water supplied, nuclear waste, environmental pollution, trade, human rights, etc.).",
            //    "Demonstrate an understanding of professional responsibility as engineers, which aims to safeguard life, and health and property; to promote the public welfare; and to establish and maintain a high standard of integrity and practice.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gursel.serpen", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "weng.kang", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Digital Design", "EECS", "4130", "Design arithmetic circuits such as adders, multipliers and dividers.",
            //    "Design a system from problem specifications with minimum hardware and minimum computation time.",
            //    "Apply digital system design principles and descriptive techniques.",
            //    "Analyze and design functional building blocks and control and timing concepts of digital systems.",
            //    "Understand timing simulation to measure delays and study signals subject to timing constraints.",
            //    "Identify a problem, formulate, design and solve the problem.",
            //    "Present results to the class using power point and able to defend their work.",
            //    "Utilize programmable devices such as FPGAs to implement digital system design.",
            //    "Model and simulate a digital system using hardware description language like VHDL.",
            //    "Distinguish among various forms of verifications.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "anthony.johnson", CommitteeRank.ViceChair);

            //newClass = CreateClass(context, systemUserAccount, "Feedback Control Systems", "EECS", "4200", "Formulate mathematical models for linear, time-invariant electrical, mechanical and electromechanical systems.",
            //    "Construct block diagram and signal flow graph representations of linear, time-invariant systems.",
            //    "Reduce block diagram and signal flow graph representations to a single transfer function.",
            //    "Determine applications of closed loop systems.",
            //    "Analyze and design control system specifications in the time domain.",
            //    "Determine the stability of control systems.",
            //    "Determine the relation between characteristic equation root location and control system performance.",
            //    "Analyze the frequency response characteristics of a control system.",
            //    "Use MATLAB and Simulink to analyze open and closed loop control systems.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.ViceChair);

            //newClass = CreateClass(context, systemUserAccount, "Communication Systems", "EECS", "4360", "Determine the spectral contents of time-domain signal by applying Fourier analysis.",
            //    "Describe and analyze the mathematical techniques of generation, transmission and reception of analog modulation signals.",
            //    "Convert analog signals to digital format using sampling and quantization techniques.",
            //    "Describe and analyze the methods of transmission of digital data using baseband and carrier modulation techniques.",
            //    "Evaluate the performance of digital data transmission in the presence of additive white Gaussian noise.",
            //    "Use software to implement the communication system and analyze its performance.",
            //    "Recognize the necessity of life-long learning and engage in life-long learning through timely exposure to the evolving and new technologies in the field of communications.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "jung.kim", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.ViceChair);

            //newClass = CreateClass(context, systemUserAccount, "Electronic Energy Processing I", "EECS", "4480", "Describe the basic operating characteristics of high-power semiconductor switching devices, including the diode, power MOSFET, BJT, IGBT, and thyristor.",
            //    "Perform circuit analytical techniques for solving transient circuits in the time domain.",
            //    "Use the concept of cyclic steady state behaviors in circuit analysis.",
            //    "Calculate average and rms values of signals in the time domain, and from the Fourier series expressions of the same.",
            //    "Characterize power transfer for non-sinusoidal periodic signals, including displacement factor, power factor, and harmonic distortion, in dc, single-phase, and three-phase systems.",
            //    "Analyze basic single-phase and three-phase controlled and uncontrolled rectifiers.",
            //    "Analyze basic non-isolated dc/dc switching converters.",
            //    "Analyze basic single-phase voltage-source inverters using square wave and sine-triangle modulation.",
            //    "Effectively extract cyclic steady state information, including average, rms, power factor, and harmonic content, from SPICE simulations of switched systems.",
            //    "Succinctly state the basic concepts of the course using one or two sentences per concept.");

            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "roger.king", CommitteeRank.Chair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "thomas.stuart", CommitteeRank.ViceChair);
            //CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "krishna.shenai", CommitteeRank.Member);

            //newClass = CreateClass(context, systemUserAccount, "Solid State Devices", "EECS", "4600", "Given the test equipment, design an experiment to measure the switching speed and power consumption of a standard Metal Oxide Semiconductor Field Effect Transistor, and implement the design after approval to measure the switching speed and power consumption.",
            //    "Given the list of materials and their properties, design a solar cell using appropriate materials, taking into account at least two realistic constraints including efficiency, cost-effectiveness, sustainability, and environmental impact of this technology.",
            //    "Identify the global, economic and environmental impact of energy harvesting technologies (e.g. solar, vibration, thermoelectric) given a specific application context such as hand-held devices, wireless sensor networks, etc.");

        }

        protected static void CreateSLOForClassWithOutcome(ABETContext context, Class newClass, ApplicationUser systemUser, string sloText, List<int> eacOutcomes, List<int> cacOutcomes)
        {
            StudentLearningObjective objective = new StudentLearningObjective();
            objective.Class = newClass;
            objective.CreatedByUser = systemUser;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = sloText;
            objective.SupportedOutcomes = new List<Outcome>();

            foreach (int id in eacOutcomes)
            {
                var outcome = context.Outcomes.Local.Where(m => m.Criteria.Name == "EAC" && m.Id == id).First();
                objective.SupportedOutcomes.Add(outcome);
            }

            foreach (var id in cacOutcomes)
            {
                var outcome = context.Outcomes.Local.Where(m => m.Criteria.Name == "CAC" && m.Id == id).First();
                objective.SupportedOutcomes.Add(outcome);
            }

            newClass.LearningObjectives.Add(objective);
        }

        protected static void CreateCommitteeMemberForClass(ABETContext context, Class newClass, ApplicationUser systemUser, UserManager<ApplicationUser> userManager, string username, CommitteeRank rank)
        {
            ApplicationUser committeeUser = userManager.FindByName(username);

            CommitteeMember member = new CommitteeMember();
            member.Class = newClass; 
            member.User = committeeUser;
            member.CommitteeRank = rank;
            member.IsActive = true;
            member.CreatedOn = DateTime.UtcNow;
            member.CreatedByUser = systemUser;

            newClass.CommitteeMembers.Add(member);
        }

        protected static Class CreateClass(ABETContext context, ApplicationUser systemUser, string className, string classPrefix, string classNumber)
        {
            Class newClass = new Class();
            newClass.IsActive = true;
            newClass.Name = className;
            newClass.Prefix = classPrefix;
            newClass.Number = classNumber;
            newClass.CreatedOn = DateTime.UtcNow;
            newClass.CreatedByUser = systemUser;
            newClass.LearningObjectives = new List<StudentLearningObjective>();
            newClass.CommitteeMembers = new List<CommitteeMember>();

            context.Classes.Add(newClass);

            return newClass;
        }
    }
}
